# Content Security Policy 101

This repository is created to be used as a guide when implementing Content Security Policy in your wep app. It is a clickable prototype of a page where you're brought on a journey from a page with no CSP through several implementation steps to a finished product.

### Setup

Open CSP.sln in Visual Studio and run it.

## Content Security Policy-cheat sheet

The form of the CSP-header:

`Content-security-policy: policy1 arguments for policy1; policy2 argument;`

### Upgrade insecure requests

`upgrade-insecure-requests`

Upgrade insecure requests will attempt to load all http-requests over https. If the resource doesn't exist on https, the requests will fail (404).

### Block all mixed content

`block-all-mixed-content`

Blocks all content from being loaded over http. Not necessary if upgrade-insecure-request is on.

### Setting sources

`[xxx]-src 'self' https: http://some.url.com`

There are many different sources you may restrict sources from, and they all use the same syntax for declaring sources and allow the same diffent kinds, so I'll show them here:

`'self'` - My own domain.

`https:` - Or other schemes, although the others aren't recommended. (`http:`, `data:`, `mediastream:`, `blob:`, and `filesystem:`) If you use these in your web app, they should be allowed specifically for the urls from where they are used.

`*` - Allows everything.

`'none'` - Allows no sources.

`https://www.example.com` - Allows everything from www.example.com. You may also use wildcards or port specification. `https://*.example.com` allows all subdomains of example.com. `https://www.example.com:443` allows only 443-port of www.example.com.

`'unsafe-inline'` - Allows inline sources, suchs as `<script>js</script>` or `<style>css</style>`.

`'unsafe-eval'` - Allows the use of `eval()` and other methods which creates runnable code from strings.

`'nonce-<somerandomvalue>'` - Allows all elements with `nonce=<somerandomvalue>` to bypass the other CSP-rules. It is important that the nonce is recalculated in a cryptographically secure way on every reload. If the nonce is guessable, attackers will be able to bypass all your other CSPs.

`sha256-<base64value>` - Allows scripts or styles that hash to certain base64-values to be run.

### Different sources to be restricted

#### connect-src
Specifies valid sources that can be loaded using the following interfaces:
- `<a>`
- `ping`
- `Fetch`
- `XMLHttpRequest`
- `WebSocket`
- `EventSource`

Falls back to `default-src` if not specified.

#### font-src
Specifies valid sources from where one may load fonts. Falls back to `default-src` if not specified.

#### frame-src
Whitelists sources for nested content, such as `iframe` and `frame`. Falls back to `default-src` if not specified.

#### img-src
Specifies valid sources for images and favicons. Falls back to `default-src` if not specified.

#### manifest-src
Specifies which manifest (for Progressive Web Apps) may be applied to the resource. Falls back to `default-src` if not specified.

#### media-src
Specifies valid sources for `<audio>` and `<video>`-elements. Falls back to `default-src` if not specified.

#### object-src
Specifies valid sources for `<object>`, `<embed>`, `<applet>`-elements. Falls back to `default-src` if not specified.

#### script-src
Specifies valid sources from where `<script>`-tags may load scripts. This also includes inline event handlers such as `onclick` and XSLT-stylesheets. Falls back to `default-src` if not specified.

#### style-src
Specifies valid sources from where `<style>`-tags may load styles. This also includes inline styles. Falls back to `default-src` if not specified.

#### worker-src
Specifies valid sources for `Worker`, `ServiceWorker`, and `SharedWorker`-scripts. Falls back to `script-src` which again falls back to `default-src` if not specified.

#### form-actions
Specifies valid sources for forms to submit to. *Does not fall back to anything, which means that all form-actions are allowed if this is not set.*

