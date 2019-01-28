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

`https://www.example.com` - Allows everything from www.example.com. You may also use wildcards: `https://*.example.com` allows all subdomains of example.com. `https://www.example.com:443` allows only 443-port of www.example.com.

