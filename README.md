# Film Franchise Ratings

## Table of Contents

 * [Demo](#demo)
 * [Explanation](#explanation)
 * [Live Version](#live-version)
 * [Compatibility](#compatibility)
 * [Testing](#testing) 
 * [File Descriptions](#file-descriptions)
 * [Technologies](#technologies)
 * [Validation](#validation)

## Demo

![Demo](https://raw.githubusercontent.com/Robson/Film-Franchise-Ratings/master/Demo.gif)

## Explanation

An interactive webpage for exploring the ratings of popular film franchises. The ratings from the IMDb and Metacritic can be shown. Filters are available for the franchises, such as showing all the franchises that started in the 1980s.

## Live Version

https://robson.plus/film-franchise-ratings/

## Compatibility

The output for this project is designed for desktop and mobile.

| Platform | OS      | Browser          | Version | Status  |
| :------- | :------ | :--------------- | :------ | :------ |
| Desktop  | Windows | Firefox          | 85      | Working |
| Desktop  | Windows | Opera            | 74      | Working |
| Desktop  | Windows | Chrome           | 88      | Working |
| Desktop  | Windows | Edge             | 88      | Working |
| Mobile   | Android | Chrome           | 85      | Working |

Last tested on 14th February 2021.

## Testing

To run this on your computer:
 * [Download the repository](https://github.com/Robson/Film-Franchise-Ratings/archive/master.zip)
 * Unzip anywhere
 * Open *index.html* in your browser

## File Descriptions

### Everything in the GetImdbFilmFranchiseData folder

This is the C# code that stores the franchises and gets all of the data from the IMDb. It writes that data to data.js

### data.js

All of the film franchise data. Film names, years, ratings, etc. The ID is the IMDb ID for the film.

### index.html + style.css

The files for the interactive webpage.

## Technologies

This is built using:
 * C# (.NET Core)
 * HTML
 * CSS
   * <a href="https://github.com/twbs/bootstrap">Bootstrap</a>
 * JavaScript
   * <a href="https://github.com/d3/d3">D3.js</a>
     * <a href="https://github.com/harrystevens/d3-regression">d3-regression</a>

## Validation
	 
<a href="https://validator.w3.org/nu/?doc=https%3A%2F%2Frobson.plus%2Ffilm-franchise-ratings%2F"><img src="https://www.w3.org/Icons/valid-html401-blue" alt="Valid HTML" /></a>

<a href="http://jigsaw.w3.org/css-validator/validator?uri=https%3A%2F%2Frobson.plus%2Ffilm-franchise-ratings%2Fstyle.css&profile=css3svg&usermedium=all&warning=1"><img src="https://jigsaw.w3.org/css-validator/images/vcss-blue" alt="Valid CSS" /></a>

[![X](https://www.codefactor.io/repository/github/robson/Film-Franchise-Ratings/badge?style=flat-square)](https://www.codefactor.io/repository/github/robson/Film-Franchise-Ratings)