## An analysis of the study of all HTML elements until and including HTML5

[Inventory taking](https://github.com/Sathyaish/Practice/blob/master/HTML5/Elements.md) of [all the HTML elements](https://github.com/Sathyaish/Practice/blob/master/HTML5/Elements-All.md) until and including HTML5 has revealed that there aren't very many important HTML tags that I didn't know of already. One can make a list of the ones that actually matter in the building of websites simply by recollection from memory and experience of having used HTML to whatever degree. There's only a few other important ones that one might not be easily able to recollect but would have used in the past and would know of them when they're mentioned.

Here, I categorize all elements as *ones that are utterly useless*, *the useful ones*, *the useful ones that have to do with appearance, or are user interface elements or controls*, *ones that are semantic and utterly useless*, *ones that have been deprecated or are soon likely to be*, and so on. I still don't know if these will be the exact classification I will end up with. I am simply trying to arrange them in my head so that only the most important ones are stored in the area of my memory where I need to recall them in daily use.

### How I define usefulness
Utility is subjective, and since I am doing this exercise only for my own benefit, so I must define what it means to me for an element be considered useful.

Furthermore, not only is usefulness subjective, but its subjectivity is rooted in the value system or goal it serves. So, at different times, which tag / element, or for that matter any idea, is useful to me will differ. When I study HTML only for the sake of study, i.e. to be able to teach it to others and to be able to answer any question about its vocabulary effectively, then *all* the elements are useful. But when I have to build something, I must ruthelessly define a very restrictive sense of utitlity.

Hence, for this time, my goal being to build software, my definition of utility or usefulness is rather restrictive. If anything is not *absolutely necessary* in that *I would be better off doing it with a declarative HTML tag than by defining CSS on an ambivalant HTML element like `<span>`*, then such an element is *not* useful for me to rent my brain space for, at least at this time.

It may be argued that anything could be done by defining CSS on the ambivalant `<span>`. So, why bother making this list at all? So, I must furnish a few examples.

For e.g. one needs not to argue about the normative elements such as `html`, `body`, `meta`, `link`, `base` and so on.

Further in the reportoire of examples, I couldn't draw a table as easily with CSS as I could by using the `table` element. However, I could easily emphasise anything I wanted to without using the `em` element.

Simlary, elements such as `var`, `kbd`, `tt` and `code` are extremely narrow in their use-cases, and are mostly purely semantic, their aesthetic being the same. I would put them all in one category that I *kind of know and even remember but don't care so much about.*

### Until before HTML5

#### Important

##### Normative
html, head, body, script, style, title, base, link, meta. 

##### Useful for divinding content into sections
p, br, div, span, h1 - h6, hr.

##### User interface elements
img, input, image, map, picture, source, area, button, option, select, optgroup, menu, menuitem, form, fieldset, legend, textarea, dialog, label, multicol (might be deprecated, I think), iframe (See [issues with using frames](https://github.com/Sathyaish/Practice/blob/master/HTML5/Questions.md#IssuesWithFrames)).

##### Lists
li, ol, ul, dd, dl, dt

##### Table related
table, td, tr, th, thead, tbody, tfoot, caption, col, colgroup, 

##### Redundant because they change appearance of normal inline text, so they are easily replaceable with CSS, but just keep them around
b, i, u, s, strike, sup, sub, small, big, q, blockquote, strong, del, ins.


#### Not useful to me

##### Embedded external object or backward compatibility related
object, param, applet, noembed, noscript.

##### Appearance only related
center, font, marquee, blink, bgsound, cite, 

##### Semantic
abbr, address, dfn, dir, isindex, acronym, main

##### Internationalization
bdo (will be deprecated in the favor of the new HTML5 `bdi` listed in a later section), rtc

##### All do the same thing, some are semantic, some are purely redundant as they overlap in meaning, some are just plain symptoms of the confusion present within the W3C
var, xmp, samp, pre, code, listing, kbd, plaintext, tt

##### Shadow DOM related and hence not meant to be used within user-HTML
content, shadow, slot

##### Frame related and now will be deprecated
frame, frameset, noframes. See [issues with using frames](https://github.com/Sathyaish/Practice/blob/master/HTML5/Questions.md#IssuesWithFrames).

##### Tries to make HTML into a template engine without actually providing any useful function
template

##### Just plain useless
basefont, nextid, nobr, element, spacer.



### Of the HTML5 tags / elements

#### Semantic
article, nav, aside, header, footer, figure, figcaption, section, summary, details, data, datalist, wbr, time

#### User interface element
meter, mark, progress, output, audio, video, canvas, source, track, embed

#### Semantic but utterly useless or confusing
hgroup

#### The committee realized they were mistakes and so they will soon be removed even inspite of the fact that they were just introduced
command (semantic), keygen

#### Internationalization
bdi, ruby, rp, rt


