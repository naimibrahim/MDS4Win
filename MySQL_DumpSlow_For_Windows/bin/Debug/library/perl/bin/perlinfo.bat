@rem = '--*-Perl-*--
@echo off
if "%OS%" == "Windows_NT" goto WinNT
perl -x -S "%0" %1 %2 %3 %4 %5 %6 %7 %8 %9
goto endofperl
:WinNT
perl -x -S %0 %*
if NOT "%COMSPEC%" == "%SystemRoot%\system32\cmd.exe" goto endofperl
if %errorlevel% == 9009 echo You do not have Perl in your PATH.
if errorlevel 1 goto script_failed_so_exit_with_non_zero_val 2>nul
goto endofperl
@rem ';
#!/usr/bin/perl
#line 15

use HTML::Perlinfo;
use Getopt::Long;
use Pod::Usage;
use strict;
use warnings;

my $version = "1.02";
my %Opts;

if ( !@ARGV ) {
    pod2usage(0);
}

GetOptions(\%Opts, qw[ help|? version all i:s c:s g:s m:s e:s ] ) 
	or die pod2usage(0);

pod2usage(1) if $Opts{help};


if ($Opts{version}) {
  print STDERR "perlinfo version $version\n";
  print STDERR "HTML::Perlinfo version $HTML::Perlinfo::VERSION\n";
  print STDERR "Copyright (c) 2009 by Mike Accardo\n";
  exit;
}

my %hok = (
      i => { o=> 'INFO_ALL',      f=>'perlinfo.html'},
      c => { o=> 'INFO_CONFIG',   f=>'perlconfig.html'},
      g => { o=> 'INFO_GENERAL',  f=>'perlversion.html'},
      e => { o=> 'INFO_VARIABLES',f=>'variables.html'},
      m => { o=> 'INFO_MODULES',  f=>'perlmodules.html'},
  );

if ($Opts{all}) {
  $Opts{$_} = $hok{$_}{f} for (keys %hok); 
  delete $Opts{all};
}

for my $key ( keys %Opts ) {
	$Opts{$key} = $hok{$key}{f} if ( !$Opts{$key} );
        create_file($Opts{$key}, $hok{$key}{o});	
}	

sub create_file {
   my ($file_name, $perlinfo_option) = @_;
   if (-e $file_name && !(overwrite_file($file_name))) {
      print "exiting ...\n"; 
   }
   else {
    open (WR, ">$file_name") or die "Can't open $file_name: $!"; 
	print WR perlinfo($perlinfo_option);
    close WR;
    print "Saved file $file_name\n";	
   }    

}

sub overwrite_file {
  my $file_name = shift;
  print "Overwrite existing file $file_name? (Y/N)\n";
  chomp(my $answer = <>);
  return ($answer =~ /y/i) ? 1 : 0; 
 
}

1;
=pod 

=head1 NAME

perlinfo - a command-line frontend to HTML::Perlinfo

=head1 DESCRIPTION

See L<HTML::Perlinfo> for one.

=head1 SYNOPSIS

    perlinfo -i
    perlinfo [-help] [-version] [-all] [-i|-c|-g|-m|-e] <FileName> ...

=head1 OPTIONS

All options (except for I<help> and I<version>) use the perlinfo function to produce a complete HTML page in the current working directory. The following table shows the flags corresponding perlinfo option and the name under which the file is saved.    

  flag | perlinfo option | file name

  -i   | INFO_ALL        | perlinfo.html
  -c   | INFO_CONFIG     | perlconfig.html
  -g   | INFO_GENERAL    | perlversion.html
  -m   | INFO_MODULES    | perlmodules.html
  -e   | INFO_VARIABLES  | variables.html 

You can specify your own file name, including the absolute path name, after the flag.

=over

=item -all

Saves you all the pages at once.  

=item -help

help! help! help!   

=item -version

perlinfo and HTML::Perlinfo versions

=back

=head1 EXAMPLES
     
   perlinfo -i

   'Saved file perlinfo.html'

   perlinfo -i /home/paco/www/perl-info.html

   'Saved file /home/paco/www/perl-info.html' 

=head1 COPYRIGHT

Copyright (c) 2009 by Mike Accardo

This program is distributed under the same terms as perl itself.
See http://perl.org/ or http://cpan.org/ for more info on that.

=cut

__END__
:endofperl
