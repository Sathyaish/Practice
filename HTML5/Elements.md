## Elements

There is an [HTML element reference on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element) that classifies elements based on function. However, I am classifying them as *what existed earlier*, *what was added* and *what was removed*, and then a long list of *all that there is now,* because such a classification helps my brain take an inventory of the entire gamut, label and store information and concepts better.

## At a glance
The listing below indicates that there were 108 elements prior to the advent of HTML5. 15 of these were removed, 93 retained, and a new 31 added. Thus making the total number of elements now valid in HTML5 to be 124.

![alt text](https://raw.githubusercontent.com/Sathyaish/Practice/master/HTML5/images/Breakup-Elements.png "A break-up of the number of HTML elements that existed before, were deprecated and newly introduced by HTML5, thus arriving at the total number of elements in use in HTML5.")

### Elements that existed in HTML4 and were brought into HTML5
This list does not include the elements that have been deprecated by HTML5. Therefore, the total number of elements that existed prior to HTML5 are these 93 plus the deprecated 15 listed in a following section. That is 108 elements.

| S.No. | Element | Explanation |
| ---- | -------- | ----------- |
| 1. | a | | |
| 2. | [abbr]() | <p>Represents an abbreviation or acronym and optionally provides a full description for it. If present, the `title` attribute must contain this full description and nothing else.</p><p>For e.g.</p><p> `<abbr title = "Laugh out Loud">LOL</abbr>`</p>  | |
| 3. | [address]() |<p>Indicates that the enclosed HTML provides contact information for a person or people, or for an organization.</p><p>The contact information provided by an `<address>` element's contents can take whatever form is appropriate for the context, and may include any type of contact information is needed, such as physical address, URL, email address, phone number, social media handle, geographic coordinates, and so forth. It should include the name of the person, people, or organization to which the contact information refers.</p><p>`<address>` can be used in a variety of contexts, such as providing a business's contact information in the page header, or indicating the author of an article by including an `<address>` element within the `<article>`</p>.| |
| 4. | [area]() | Defines a hot-spot region on an image and optionally associates it with a hyperlink text. It can only be used within a `<map>` element.| |
| 5. | b | Makes the text bold. It's called the **Bring Attention To** lement or something in HTML parlance. | |
| 6. | [base]() | Specifies the base URL to be used for all relative URL's in the document. There can only be on such in a document. And it may be read by using the `document.baseURI` property in JavaScript. | |
| 7. | [bdo]() | Bi-directional text override. Will render text in the direction / orientation you choose. For e.g. rtl (Right to left) will display the text from right to left, as if the string were reversed. | |
| 8. | [bgsound]() | Internet explorer only. Not a standard element. May be removed any time in the future. IE lets you play a sound file while you're looking at the page. Use the `<audio>` element instead. | |
| 9. | [blink]() | Non-standard. Can be removed anytime. Causes text to blink. | |
| 10. | blockquote | | |
| 11. | body | | |
| 12. | [br]() | | |
| 13. | [button]() | | |
| 14. | [caption]() | Specifies the ttile or caption of a table, and if used, is always the first child of the table element. | |
| 15. | cite | Pretentious non-sense. Used to italicize the text that represents the source of a quote or a blockquote. Used to cite a reference to a creative work or research paper or such. Read the comments on [the MDN page for this thing](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/cite). There's an interesting argument about the inclusion of the author's name in the citation. The two specifications, viz. W3C and WHATWG, prescribe opposing views on this.| |
| 16. | [code]() | Formats the text as code, i.e. under the default CSS of the browser, displays it in monofont. Just like the `Courier New` thing and the `<pre>` thing. Also compare with the `<samp>` element. | |
| 17. | col | Weird fucking non-sense. Look at [the `<table>` element page on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/table) for an example of this. Lets you attribute CSS to a specific column or a set of columns. Used with the `<colgroup>` element (next in this list) whose example also is on that page. | |
| 18. | colgroup | Read my comments about the `<col>` element in this list. Look at [the `<table>` element page on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/table) for an example of this.| |
| 19. | content | Probably is or is going to soon be deprecated. Won't be supported going forward.<p>Was meant to insert content into a [Shadow DOM](https://glazkov.com/2011/01/14/what-the-heck-is-shadow-dom/). Now is being replaced or has already been replaced with the `<slot>` element. This was anyway never meant to be used within normal HTML even earlier. Beware, most modern browsers do not support this `<content>` element even though it has not been dropped from the standards. It will soon be.</p>| |
| 20. | dd | Provides the details or the definition of the term (see `<dt>`) in a definition list (see `<dl>`). Also see the [`<dl>` page on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/dl#examples) for examples of definition lists and how they look when rendered.| |
| 21. | del | To mark text that has been deleted. Like in the "tracking change" feature. Similar element is the `<ins>` element which is meant to denote text that has been newly inserted. See [the MDN page for this `<del>` element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/del) for an example and for its attributes.| |
| 22. | dfn | Denotes the term being defined in a `<dd>`, `<dt>`, `<dl>` or `<section>` element. Totally semantic irrelvant nonsensical specimen of fuck. See, [it's own page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/dfn) says it is absolutely fucking nonsense and only semantic. | |
| 23. | [dialog]() | Interesting. See [the MDN page for the `<dialog>` element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/dialog). Represents a dialog box. It's contents are shown in a dialog box. It can even enclose a `<form>` element, in which case, the form is displayed in a dialog and when closed, the return value of the dialog is returned in the `returnValue` attribute of the `<dialog>` element. When used with a form, the `<form>` element's `method` attribute must be set to `dialog`. | |
| 24. | div | | |
| 25. | dl | A definition list. Also see the [`<dl>` page on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/dl#examples) for examples of definition lists and how they look when rendered. For a glossary, or a metadata display like key-value pairs. | |
| 26. | dt | The term being defined in a definition list (see `<dl>` and `<dd>` elements). | |
| 27. | element | <p>Obsolete. Don't use it.</p><p>The obsolete HTML <element> element was part of the **Web Components** specification; it was intended to be used to define new custom DOM elements. It was removed in favor of a JavaScript-driven approach for creating new custom elements; however, that technology is not mature and no browers fully implement it.</p>| |
| 28. | em | For emphasis.  The `<em>` element can be nested, with each level of nesting indicating a greater degree of emphasis. <p>Semantic non-sense, as [its own page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/em) concedes, albeit not without *making a fight about it* (See the section titled, "`<i>` vs. `<em>`" on that page).</p> | |
| 29. | fieldset | Used to group stuff on a form. Like a frame. | |
| 30. | form | | |
| 31. | h1 | | |
| 32. | head | | |
| 33. | hr | | |
| 34. | html | | |
| 35. | i | | |
| 36. | [iframe]() | A *frame* used to be in a *frameset*. So, documents, until HTML4, had either a `head` and `body` tags, or a `head` and a `frameset` but no `body`. The `frameset` had a bunch of `frame`s. An `iframe` is a *floating frame* within the body tag. See [its page on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/iframe). Frames and framesets have been removed from HTML5. Now, there are only `iframe`s. | |
| 37. | image | Obsolete. Ancient. Same as `img` or at least was meant to be but crept in due to the confusion among the opponents during the browser wars. | |
| 38. | img | | |
| 39. | input | The input control. Read [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input). | |
| 40. | [ins]() | Inserted text. Also see `<del>`. | |
| 41. | [kbd]() | Represents inline text that repreents user input from a keyboard, voice input or other input device. Fucking weird semantic element. Goes on and on about its rather pointless fucking uses on [this MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/kbd). | |
| 42. | label | The caption for an item on the user interface. `for` attribute or the element for which it is a caption can be contained within the `<label>` element. | |
| 43. | legend | A caption for the fieldset. | |
| 44. | li | | |
| 45. | link | To define the relationship between the current document and an external resource. For e.g. also used to define stylesheets. See [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/link) for list of attributes. | |
| 46. | listing | The HTML Listing Element (<listing>) renders text between the start and end tags without interpreting the HTML in between and using a monospaced font. See `<pre>`, `<code>`, `<samp>` and `<xmp>` elements. This one is not a standard element and it is recommended that we not use it. | |
| 47. | main | Semantic. Represents the main content within the `<body>` or within a `<section>` of a document. See [`<main> on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/main) for commentary. My impression is: so many semantic elements mess up HTML5. Plus we have CSS which can override everything. They messed it all up. | |
| 48. | map | Used with the `<area>` elements to define an image map. [MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/map). | |
| 49. | marquee | Obsolete. Do not use.<p>The HTML <marquee> element is used to insert a scrolling area of text. You can control what happens when the text reaches the edges of its content area using its attributes. See [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/marquee)</p> | |
| 50. | [menu]() | An unordered list similar to that of the `<ul>` element but semantically used for representing menus with `<menuitem>`s in it. Can be used to represent both toolbar style menus and context menus. Apparently, the browser includes these items within the browser's context menu if you make it of `type = context`." See the [MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/menu). And [try it out](). | |
| 51. | [menuitem]() | [MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/menuitem). Also see `<menu>`. | |
| 52. | [meta](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/meta) | Represents metadata that cannot be represented by the `script`, `style`, `base`, `link` and `title` elements. See [MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/meta). | |
| 53. | multicol | Obsolete. Don't use. <p>The HTML Multi-Column Layout element (<multicol>) was an experimental element designed to allow multi-column layouts and must not be used. It never got any significant traction and is not implemented in any major browsers. It's covered here only to warn you off in case you stumble on it in any other documentation.</p>| |
| 54. | nextid | <p>Bullshit Apple tyranny over W3C.</p><p><nextid> is an obsolete HTML element that served to enable the NeXT web designing tool to generate automatic NAME labels for its anchors. It was generated by that web editing tool automatically and was not to be adjusted or entered by hand. This element has the distinction of being the first element to become one of the "Lost Tags" by being eliminated from the official public DTD's of the HTML versions. It is also probably one of the least understood of all of the early HTML elements.</p> | |
| 55. | nobr | The non-standard, obsolete HTML <nobr> element prevents the text it contains from automatically wrapping across multiple lines, potentially resulting in the user having to scroll horizontally to see the entire width of the text. | |
| 56. | noembed | The `<noembed>` element is an obsolete, non-standard way to provide alternative, or "fallback", content for browsers that do not support the `<embed>` element or do not support the type of embedded content an author wishes to use. This element was deprecated in HTML 4.01 and above in favor of placing fallback content between the opening and closing tags of an `<object>` element.| |
| 57. | noscript | The HTML `<noscript>` element defines a section of HTML to be inserted if a script type on the page is unsupported or if scripting is currently turned off in the browser. See an example on [its MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/noscript). | |
| 58. | object | The HTML `<object>` element represents an external resource, which can be treated as an image, a nested browsing context, or a resource to be handled by a plugin. See [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/object) for an example. Also see [Embed vs. Object on StackOverflow](https://stackoverflow.com/a/1244854/303685). | |
| 59. | ol | Ordered list. | |
| 60. | optgroup | Creates a group of `<options>` within a `<select>`. See [example on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/optgroup). | |
| 61. | [option]() |  Used to define an item contained in a `<select>`, an `<optgroup>`, or a `<datalist>` element. As such, <option> can represent menu items in popups and other lists of items in an HTML document. [Examples on the `<select>` page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select). See list of attributes on [its own MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/option). [Try it](). | |
| 62. | p | Paragraph | |
| 63. | param | See `<object>`. A parameter for the embedded *object*, i.e. the external resource. | |
| 64. | picture | <p>Serves as a container for zero or more `<source>` elements and one `<img>` element to provide versions of an image for different display device scenarios. The browser will consider each of the child `<source>` elements and select one corresponding to the best match found; if no matches are found among the `<source>` elements, the file specified by the `<img>` element's `src` attribute is selected. The selected image is then presented in the space occupied by the `<img>` element.</p><p>To select the optimal image, the user agent examines each source's `srcset`, `media`, and `type` attributes to select a compatible image that best matches the current layout of the page, the characteristics of the display device, and so forth.</p><p>See its MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/picture) for an example. | |
| 65. | plaintext | <p>Obsolete. Not to be used. Totally non-sensical element. Here is what [its MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/plaintext) reads:</p><p>The **HTML Plaintext Element** (`<plaintext>`) renders everything following the start tag as raw text, without interpreting any HTML. There is no closing tag, since everything after it is considered raw text.</p><p>Related: `<pre>`, `<code>`, `<samp>`, `<listing>`, `<xmp>` | |
| 66. | [pre]() | Pre-formatted text that should be displayed as it. Line breaks as line breaks, tabs and tabs, and so on, in a monospace font. Just like the `<code>` thing but only with different semantics. Of course, everything is overridable with CSS. Compare with `<code>` and `<samp>`. | |
| 67. | q | Short inline quote that doesn't require paragraph breaks. The browser surrounds it with quotation marks. [Example on the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/q). | |
| 68. | [rtc]() | <p>See the newly introduced `<rp>`, `<rt>` and `<ruby>` elements. In all fairness, while I understand the other elements I mentioned by reading their documentation, I neither understand this element nor do I see it being refered to in any example. Read [the MDN page for this `<rtc>` element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/rtc) and see if you can understand what it means.</p><p>The text on the MDN page reads:</p><p>The HTML **Ruby Text Container** (`<rtc>`) element embraces semantic annotations of characters presented in a ruby of `<rb>` elements used inside of `<ruby>` element. <rb> elements can have both pronunciation (`<rt>`) and semantic (`<rtc>`) annotations.</p> | |
| 69. | [samp]() | Used to display inline text which represents sample or quoted output from a computer program, in a monospaced font. Compare with `<code>` and `<pre>`. See an example here on [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/samp). Not sure but it looks like this element was meant only to be for *inline* text. However, with CSS these days, everything being overridable, these distinctions are merely semantic and not aesthetic. | |
| 70. | script | | |
| 71. | select | A control that provides a menu (or drop-down list) of options to select from. See attributes and example on [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select). | |
| 72. | shadow | <p>Obsolete.</p><p>The HTML `<shadow>` element—an obsolete part of the **Web Components** technology suite—was intended to be used as a shadow DOM insertion point. You might have used it if you have created multiple shadow roots under a shadow host. It is not useful in ordinary HTML.</p>| |
| 73. | slot | An insertion point for Shadow DOM. Related: `<content>`, `<shadow>`. | |
| 74. | small | Makes the text one size smaller. | |
| 75. | spacer | <p><spacer> is an obsolete HTML element which allowed insertion of empty spaces on pages. It was devised by Netscape to accomplish the same effect as a single-pixel layout image, which was something web designers used to use to add white spaces to web pages without actually using an image. However, <spacer> no longer supported by any major browser and the same effects can now be achieved using simple CSS.</p><p>Firefox, which is the descendant of Netscape's browsers, removed support for <spacer> in version 4.</p>| |
| 76. | span | Inline container which does not represent anything. | |
| 77. | strong | Makes it bold. | |
| 78. | style | To specify a style sheet. | |
| 79. | sub | Subscript. | |
| 80. | sup | Super-script. | |
| 81. | [table](https://github.com/Sathyaish/Practice/blob/master/HTML5/Elements.md) | Look at [the MDN page for the `<table>` element](https://github.com/Sathyaish/Practice/blob/master/HTML5/Elements.md). | |
| 82. | tbody | Semantic. A set of rows representing the body of the table. Useful for printers on screen, printers, and other devices, and even for accessibility. See [example on the MDN `<tbody>` page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tbody). | |
| 83. | td | A table cell. | |
| 84. | template | <p>Bullshit. Here's where HTML5 is also trying to be of needless assistance to templating engines but without actually being of any.</p><p>The [MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/template) reads:</p><p>The HTML `<template>` element is a mechanism for holding client-side content that is not to be rendered when a page is loaded but may subsequently be instantiated during runtime using JavaScript.</p><p>Think of a template as a content fragment that is being stored for subsequent use in the document. While the parser does process the contents of the `<template>` element while loading the page, it does so only to ensure that those contents are valid; the element's contents are not rendered, however.</p>| |
| 85. | textarea | A multi-line plain text editing control. That is, a big text box in which many lines can fit. | |
| 86. | tfoot | Semantic. Defines a set of rows summarizing the columns of the table. See `<tbody>`. | |
| 87. | th | Semantic. See `<tbody>`. Also see the [`<th>` page on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/th) for associated attributes. | |
| 88. | thead | Semantic. See `<tbody>`. | |
| 89. | title | | |
| 90. | tr | A row of a table. | |
| 91. | ul | An unordered list. | |
| 92. | var | <p>The HTML **Variable element** (`<var>`) represents the name of a variable in a mathematical expression or a programming context. It's typically presented using an italicized version of the current typeface, although that behavior is browser-dependent.</p><p>See also `<code>`, `<kbd>`, `<samp>`, `<xmp>`, `<listing>`, `<pre>`.</p> | |
| 93. | xmp | <p>Obsolete. Use `<pre>` instead.</p><p>The HTML **Example Element** (`<xmp>`) renders text between the start and end tags without interpreting the HTML in between and using a monospaced font. The HTML2 specification recommended that it should be rendered wide enough to allow 80 characters per line.</p><p><b>Note:</b>Do not use this element.<br/>It has been deprecated since HTML3.2 and was not implemented in a consistent way. It was completely removed from the language in HTML5.</p> | |

### Elements deprecated by HTML5
| S.No. | Element | Explanation |
| ---- | -------- | ----------- |
| 1. | acronym | Use `<abbr>` instead. | |
| 2. | applet | Was used to embed an applet. Use `<object>` instead. | |
| 3. | basefont | <p>The obsolete HTML Base Font element (`<basefont>`) sets a default font face, size, and color for the other elements which are descended from its parent element. With this set, the font's size can then be varied relative to the base size using the `<font>` element.</p><p>You should not use this element; instead, you should use CSS properties such as font, font-family, font-size, and color to change the font configuration for an element and its contents.</p>| |
| 4. | big | Makes the font one level larger. | |
| 5. | center | Centers the text within a container. | |
| 6. | dir | Absolutely useless semantic element that was meant to represent a folder or a bunch of files with CSS to be applied by the user as he pleased. [MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/dir) | |
| 7. | font | Defines a font. | |
| 8. | frame | Also see `<iframe>` and `<frameset>`. | |
| 9. | frameset | See [frameset on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/frameset) | |
| 10. | isindex | <p>WTF! Another useless semantic element that left everything to be done by the user. The [page on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/isindex) reads:</p> <p>`<isindex>` is an obsolete HTML element that puts a text field in a page for querying the document. `<isindex>` was providing a single line text input for entering a query string. When sent, the server would return a list of pages matching the query. Its supports depended on both the browser and the server to react to the query.</p><p>`<isindex>` is deprecated as of HTML 4.01, because the same behaviour can be achieved with an HTML form. All major browsers have now removed `<isindex>`,  and it is has been classified as a non-conforming feature in the WHATWG HTML living standard.</p> | |
| 11. | noframes | What if the browser did not support frames? Renders that content. Like `<noscript>`, `<noembed>`, etc. | |
| 12. | s | Same as strike-through. | |
| 13. | strike | Strike-through. | |
  | 14. | tt | <p>Obsolete. Teletype Text. Same as `<code>`, `<pre>`,etc. Here's what [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tt) says:</p><p>The obsolete HTML Teletype Text element (`<tt>`) creates inline text which is presented using the user agent's default monospace font face. This element was created for the purpose of rendering text as it would be displayed on a fixed-width display such as a teletype, text-only screen, or line printer.</p> | |
| 15. | u | Underline. | |

### New HTML5 tags / elements
| S.No. | Element | Explanation |
| ---- | -------- | ----------- |
| 1. | article | Represents a self-contained composition in a document, page, application, or site, which is intended to be independently distributable or reusable (e.g., in syndication). Examples include: a forum post, a magazine or newspaper article, or a blog entry. | |
| 2. | aside | Represents a portion of a document whose content is only indirectly related to the document's main content. Asides are frequently presented as sidebars or call-out boxes. | |
| 3. | audio | To play audio without using a plug-in. | |
| 4. | bdi | Bidirectional isolation. | |
| 5. | canvas | Use the HTML `<canvas>` element with either the canvas scripting API or the WebGL API to draw graphics and animations. | |
| 6. | command | Deprecated. Was meant to represent a command that can be invoked from a menu or some such. Was immediately repealed / revoked when the committee discovered the imbecility of those that thought it up. | |
| 7. | data | You use it to store any arbitrary data value for a control that doesn't allow or have a facility to store data. For an example, see [the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/data) where each list item (`<li>`) contains a `<data>` element to store its `value`. Looks like this is redundant now a days given we can add custom attributes to any HTMl element. | |
| 8. | datalist | Represent a list of data that can be used by one or more controls. See an [example on the MDN page](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/datalist). The document says: <p>The HTML `<datalist>` element contains a set of `<option>` elements that represent the values available for other controls.</p> | |
| 9. | details | See `<summary>`. | |
| 10. | embed | <p>The HTML `<embed>` element embeds external content at the specified point in the document. This content is provided by an external application or other source of interactive content such as a browser plug-in.</p><p><blockquote><b>Note:</b> This topic documents only the element that is defined as part of HTML5. It does not address earlier, non-standardized implementation of the element.</blockquote></p><p>Keep in mind that most modern browsers have deprecated and removed support for browser plug-ins, so relying upon <embed> is generally not wise if you want your site to be operable on the average user's browser.</p><p>Also see [Embed vs. Object on StackOverflow](https://stackoverflow.com/a/1244854/303685).</p> | |
| 11. | figcaption | | |
| 12. | figure | <p>Represents self-contained content, frequently with a caption (`<figcaption>`), and is typically referenced as a single unit.</p><p><b>Usage: </b><ul><li>Usually a `<figure>` is an image, illustration, diagram, code snippet, etc., that is referenced in the main flow of a document, but that can be moved to another part of the document or to an appendix without affecting the main flow.</li><li>Being a sectioning root, the outline of the content of the `<figure>` element is excluded from the main outline of the document.</li><li>A caption can be associated with the `<figure>` element by inserting a <figcaption> inside it (as the first or the last child).</li><ul>All this invokes the thoughts "MS Word online" or "online authoring," or "syndication of content by crawlers and search engines," or "semantic microdata formats," or "image syndication."</p> | |
| 13. | footer | The footer of anything that represents a unit. Like that of a section or of the whole page. The one that sticks to the bottom of the section or page it is associated with. | |
| 14. | header | Supposed to represent the top part of a website, the one that has the logo, application name and stuff. You can put all that stuff in a `<header>` instead of a `<div>`, or put that `<div>` inside a `<header>. | |
| 15. | hgroup | The most idiotic semantic element with the most confusing and convoluted example on the MDN and I still do not understand what it is for and how to use it even after reading the [page on the MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/hgroup). | |
| 16. | keygen | Deprecated. Was meant to generate the public key part of PKI for a `<form>`. | |
| 17. | mark | Represents text which is marked or highlighted for reference or notation purposes. | |
| 18. | meter | Represents either a scalar value within a known range or a fractional value. Draws a nice progress-bar like UI to represent the value. | |
| 19. | nav | Supposed to represent the left or right or some place else navigation bar. Even the toolbar at the top that represents navigable links. Remember, semantics, not position. | |
| 20. | output | User interface control. Semantic. To represent the output of an operation. You have to code the part that puts the output in there based on some event or trigger so this is purely semantic. As with all semantic elements, the motif question that surfaces in the mind is -- then why have it? Remember! For machines to consume to make better sense of the world they are searching, indexing or cataloguing. [Example on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/output). | |
| 21. | progress | A progress bar control. | |
| 22. | rp | Ruby annotation pronunciation. | |
| 23. | rt | Ruby annotation tranliteration. | |
| 24. | ruby | Ruby annotation parent element. For translation, transliteration and pronuncitation of South East Asian languages. | |
| 25. | section | A section within a document. What the `<div>` did. | |
| 26. | source | Specifies multiple media resources for the `<picture>`, the `<audio>` element, or the `<video>` element. It is an empty element. It is commonly used to serve the same media content in multiple formats supported by different browsers. [Example](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/source). | |
| 27. | summary | Along with `<details>`, provides a nice user interface where you see the *summary* and an arrow to its left. You click the arrow and the summary collapses to present *details*. | |
| 28. | time | To represent a unit of time. Either absolute date, or absolute time, or a time-span. [Example on MDN](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/time). | |
| 29. | track | Represents text annotation / captions for an audio or video track. The HTML `<track>` element is used as a child of the media elements `<audio>` and `<video>`. It lets you specify timed text tracks (or time-based data), for example to automatically handle subtitles. The tracks are formatted in WebVTT format (.vtt files) — [Web Video Text Tracks](https://developer.mozilla.org/en-US/docs/Web/API/WebVTT_API). [Example](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/track). | |
| 30. | video | To play video without using a plug-in. | |
| 31. | wbr | Represents a word break opportunity—a position within text where the browser may optionally break a line, though its line-breaking rules would not otherwise create a break at that location. | |

## Analysis

This exercise has revealed that there aren't very many tags that are important in practically building websites. The only few important ones are the ones I already knew and that those that one could already count from their memory and experience of having used HTML to some degree. Therefore, I would like to summarize the important ones on [this separate page](https://github.com/Sathyaish/Practice/blob/master/HTML5/Elements-Analysis.md).
