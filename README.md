# Textoid

Text editor with support for previewing variables.  

## What is the purpose of Textoid?

There are many amazing text editors out there.  That said, there are some cases in which the use of variables as placeholders make sense.  Any scenario where one is building a template is a fair example.   The purpose of Textoid is to develop a text editor that can work with variables and show samples without need to access the underlying processing that derives said samples.

## What are some features of Textoid?
- Translation of variable to sample without the need to access any underlying application code or database query.
- Persistant storage of variables and samples via .xml file.
- Real time translation of variable to sample.
- Real time highlighting of both variables and samples.

### Built with:

Visual Studio
Visual Basic (.NET Framework 4.7.2)
Winforms

## Authors

* **Dan Raub** - *Initial work* - [draub](https://github.com/draub)

## License:  

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Initial goals:

The initial goal was to create a text editor that could show both a variable (or template) view as well as an example of what the end product would look like (without the need to intersect with the code that populated the template).  The secondary goal was to use Winforms to build the ui, yet have it comform to whatever scaling the user required.   While I have a specific use case in mind, the idea was to start off with a general platform to build off of.

## Future Goals

1.  Increase settings robustness:
	1.a Currently everything is case sensitive.   Add an option for case sensitivity.
	1.b Currently only save option for variable version.   Improve save options:  autosave, save variable and sample versions, etc.
	1.c Currently a specific .xml file is used to define variables and samples.  Swap out variable .xml files based on situation.
	1.d Currently highlighting is done a specific way.   Add more options.
2.  Additional features:
	2.a  Alternative usage of 2nd text panel.  Example:  Using it to compare the similarities and differences between two files.
	2.b  Add printing functionality.
	2.c  Add more robust description to the variable options.
	2.d  Implement specific use cases.  Example:  ZPL II label previewing options.
