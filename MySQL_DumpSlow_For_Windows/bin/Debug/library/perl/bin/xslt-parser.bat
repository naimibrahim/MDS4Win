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
#!/xampp/perl/bin/perl.exe -w
#line 15

# $Id: xslt-parser,v 1.9 2001/03/01 05:22:45 hexmode Exp $

use strict;
use XML::XSLT;
use Getopt::Std;

=head1 NAME

xslt-parser - XSLT transformations

=head1 SYNOPSIS

xslt-parser [options] <project>

=head1 DESCRIPTION

xslt-parser performs stylesheet transformations.

When given a project name, it appends `.xsl' for the XSLT stylesheet
and `.xml' for the XML file to apply the stylesheet to and performs the
transformation using the XML::XSLT perl module.

=head1 OPTIONS

=over 4

=item -c

Pass through HTML::Clean.  You must have HTML::Clean installed.

=item -d

Turns debugging on.  This can produce a lot of noise.

=item -n

NoWeb.  You can use xslt-parser as a CGI script.  With this option,
it will not output the headers that are usually needed.

=item -s <file>

Specify a seperate different stylesheet.  Usually, xslt-parser will
simply append `.xsl' to the project name to get the stylesheet.  A
different stylesheet can be specified using this option.

=head1 AUTHORS

Geert Josten <gjosten@sci.kun.nl>,
Mark A. Hershberger <mah@everybody.org>

=head1 SEE ALSO

L<XML::XSLT>

The w3.org XSLT recommendation at L<http://www.w3.org/TR/xslt>

=cut

my %opt;
my $usage = "Usage: $0 [options] <project>

  -d	     turn debugging mode on
  -n	     don't print content-type
  -s <file>  use <file> instead of <project>.xsl as template
  -w	     turns warnings on\n";
getopts('cdnws:h', \%opt) || die $usage;

die $usage if $opt{h};

## global vars ##
my $noweb = $opt{n} || 0;
my $debug = $opt{d} || 0;
my $warnings = $opt{w} || 0;
my $project = shift || die $usage;
my $xslfile = $opt{'s'} || "$project.xsl";
my $xmlfile = $project;

my $xslt = XML::XSLT->new (Source   => $xslfile,
			   debug    => $debug,
			   warnings => $debug);

if (! -f $xslfile) {
  die "$xslfile does not exist.";
}

if (! -f $xmlfile) {
  $xmlfile .= ".xml";
  if (! -f $xmlfile) {
    die "$xmlfile does not exist."
  }
}

print STDERR qq{Debug   : "$debug"
NoWeb   : "$noweb"
Warnings: "$warnings"
Project : "$project"
XML-file: "$xmlfile"
XSL-file: "$xslfile"
} if $debug;

print $xslt->serve(Source       => $xmlfile,
		   clean        => $opt{c},
		   http_headers => ! $noweb);


__END__
:endofperl
