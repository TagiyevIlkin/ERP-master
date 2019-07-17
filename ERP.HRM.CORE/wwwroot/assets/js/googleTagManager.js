﻿
// Copyright 2012 Google Inc. All rights reserved.
(function () {

    var data = {
        "resource": {
            "version": "1",

            "macros": [],
            "tags": [],
            "predicates": [],
            "rules": []
        },
        "runtime": [
            [], []
        ]



    };
    var ba, ca = this || self, da = /^[\w+/_-]+[=]{0,2}$/, fa = null; var ha = function () { }, ia = function (a) { return "function" == typeof a }, ja = function (a) { return "string" == typeof a }, ka = function (a) { return "number" == typeof a && !isNaN(a) }, la = function (a) { return "[object Array]" == Object.prototype.toString.call(Object(a)) }, ma = function (a, b) { if (Array.prototype.indexOf) { var c = a.indexOf(b); return "number" == typeof c ? c : -1 } for (var d = 0; d < a.length; d++)if (a[d] === b) return d; return -1 }, na = function (a, b) { if (a && la(a)) for (var c = 0; c < a.length; c++)if (a[c] && b(a[c])) return a[c] }, oa = function (a, b) {
        if (!ka(a) ||
            !ka(b) || a > b) a = 0, b = 2147483647; return Math.floor(Math.random() * (b - a + 1) + a)
    }, ra = function (a, b) { for (var c = new pa, d = 0; d < a.length; d++)c.set(a[d], !0); for (var e = 0; e < b.length; e++)if (c.get(b[e])) return !0; return !1 }, sa = function (a, b) { for (var c in a) Object.prototype.hasOwnProperty.call(a, c) && b(c, a[c]) }, ta = function (a) { return Math.round(Number(a)) || 0 }, ua = function (a) { return "false" == String(a).toLowerCase() ? !1 : !!a }, va = function (a) { var b = []; if (la(a)) for (var c = 0; c < a.length; c++)b.push(String(a[c])); return b }, wa = function (a) {
        return a ?
            a.replace(/^\s+|\s+$/g, "") : ""
    }, xa = function () { return (new Date).getTime() }, pa = function () { this.prefix = "gtm."; this.values = {} }; pa.prototype.set = function (a, b) { this.values[this.prefix + a] = b }; pa.prototype.get = function (a) { return this.values[this.prefix + a] }; pa.prototype.contains = function (a) { return void 0 !== this.get(a) };
    var ya = function (a, b, c) { return a && a.hasOwnProperty(b) ? a[b] : c }, za = function (a) { var b = !1; return function () { if (!b) try { a() } catch (c) { } b = !0 } }, Aa = function (a, b) { for (var c in b) b.hasOwnProperty(c) && (a[c] = b[c]) }, Ba = function (a) { for (var b in a) if (a.hasOwnProperty(b)) return !0; return !1 }, Da = function (a, b) { for (var c = [], d = 0; d < a.length; d++)c.push(a[d]), c.push.apply(c, b[a[d]] || []); return c };/*
 jQuery v1.9.1 (c) 2005, 2012 jQuery Foundation, Inc. jquery.org/license. */
    var Ea = /\[object (Boolean|Number|String|Function|Array|Date|RegExp)\]/, Fa = function (a) { if (null == a) return String(a); var b = Ea.exec(Object.prototype.toString.call(Object(a))); return b ? b[1].toLowerCase() : "object" }, Ga = function (a, b) { return Object.prototype.hasOwnProperty.call(Object(a), b) }, Ha = function (a) {
        if (!a || "object" != Fa(a) || a.nodeType || a == a.window) return !1; try { if (a.constructor && !Ga(a, "constructor") && !Ga(a.constructor.prototype, "isPrototypeOf")) return !1 } catch (c) { return !1 } for (var b in a); return void 0 ===
            b || Ga(a, b)
    }, f = function (a, b) { var c = b || ("array" == Fa(a) ? [] : {}), d; for (d in a) if (Ga(a, d)) { var e = a[d]; "array" == Fa(e) ? ("array" != Fa(c[d]) && (c[d] = []), c[d] = f(e, c[d])) : Ha(e) ? (Ha(c[d]) || (c[d] = {}), c[d] = f(e, c[d])) : c[d] = e } return c }; var v = window, A = document, Ia = navigator, Ja = A.currentScript && A.currentScript.src, Ka = function (a, b) { var c = v[a]; v[a] = void 0 === c ? b : c; return v[a] }, La = function (a, b) { b && (a.addEventListener ? a.onload = b : a.onreadystatechange = function () { a.readyState in { loaded: 1, complete: 1 } && (a.onreadystatechange = null, b()) }) }, Ma = function (a, b, c) {
        var d = A.createElement("script"); d.type = "text/javascript"; d.async = !0; d.src = a; La(d, b); c && (d.onerror = c); var e; if (null === fa) b: {
            var g = ca.document, h = g.querySelector && g.querySelector("script[nonce]");
            if (h) { var k = h.nonce || h.getAttribute("nonce"); if (k && da.test(k)) { fa = k; break b } } fa = ""
        } e = fa; e && d.setAttribute("nonce", e); var l = A.getElementsByTagName("script")[0] || A.body || A.head; l.parentNode.insertBefore(d, l); return d
    }, Na = function () { if (Ja) { var a = Ja.toLowerCase(); if (0 === a.indexOf("https://")) return 2; if (0 === a.indexOf("http://")) return 3 } return 1 }, Oa = function (a, b) {
        var c = A.createElement("iframe"); c.height = "0"; c.width = "0"; c.style.display = "none"; c.style.visibility = "hidden"; var d = A.body && A.body.lastChild ||
            A.body || A.head; d.parentNode.insertBefore(c, d); La(c, b); void 0 !== a && (c.src = a); return c
    }, Pa = function (a, b, c) { var d = new Image(1, 1); d.onload = function () { d.onload = null; b && b() }; d.onerror = function () { d.onerror = null; c && c() }; d.src = a; return d }, Qa = function (a, b, c, d) { a.addEventListener ? a.addEventListener(b, c, !!d) : a.attachEvent && a.attachEvent("on" + b, c) }, Ra = function (a, b, c) { a.removeEventListener ? a.removeEventListener(b, c, !1) : a.detachEvent && a.detachEvent("on" + b, c) }, D = function (a) { v.setTimeout(a, 0) }, Ua = function (a, b) {
        return a &&
            b && a.attributes && a.attributes[b] ? a.attributes[b].value : null
    }, Va = function (a) { var b = a.innerText || a.textContent || ""; b && " " != b && (b = b.replace(/^[\s\xa0]+|[\s\xa0]+$/g, "")); b && (b = b.replace(/(\xa0+|\s{2,}|\n|\r\t)/g, " ")); return b }, Wa = function (a) { var b = A.createElement("div"); b.innerHTML = "A<div>" + a + "</div>"; b = b.lastChild; for (var c = []; b.firstChild;)c.push(b.removeChild(b.firstChild)); return c }, Xa = function (a, b, c) {
        c = c || 100; for (var d = {}, e = 0; e < b.length; e++)d[b[e]] = !0; for (var g = a, h = 0; g && h <= c; h++) {
            if (d[String(g.tagName).toLowerCase()]) return g;
            g = g.parentElement
        } return null
    }, Ya = function (a, b) { var c = a[b]; c && "string" === typeof c.animVal && (c = c.animVal); return c }; var Za = /^(?:(?:https?|mailto|ftp):|[^:/?#]*(?:[/?#]|$))/i; var $a = {}, ab = function (a, b) { $a[a] = $a[a] || []; $a[a][b] = !0 }, bb = function (a) { for (var b = [], c = $a[a] || [], d = 0; d < c.length; d++)c[d] && (b[Math.floor(d / 6)] ^= 1 << d % 6); for (var e = 0; e < b.length; e++)b[e] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789-_".charAt(b[e] || 0); return b.join("") }; var cb = /:[0-9]+$/, db = function (a, b, c) { for (var d = a.split("&"), e = 0; e < d.length; e++) { var g = d[e].split("="); if (decodeURIComponent(g[0]).replace(/\+/g, " ") === b) { var h = g.slice(1).join("="); return c ? h : decodeURIComponent(h).replace(/\+/g, " ") } } }, hb = function (a, b, c, d, e) {
        b && (b = String(b).toLowerCase()); if ("protocol" === b || "port" === b) a.protocol = fb(a.protocol) || fb(v.location.protocol); "port" === b ? a.port = String(Number(a.hostname ? a.port : v.location.port) || ("http" == a.protocol ? 80 : "https" == a.protocol ? 443 : "")) : "host" === b &&
            (a.hostname = (a.hostname || v.location.hostname).replace(cb, "").toLowerCase()); var g = b, h, k = fb(a.protocol); g && (g = String(g).toLowerCase()); switch (g) {
                case "url_no_fragment": h = gb(a); break; case "protocol": h = k; break; case "host": h = a.hostname.replace(cb, "").toLowerCase(); if (c) { var l = /^www\d*\./.exec(h); l && l[0] && (h = h.substr(l[0].length)) } break; case "port": h = String(Number(a.port) || ("http" == k ? 80 : "https" == k ? 443 : "")); break; case "path": a.pathname || a.hostname || ab("TAGGING", 1); h = "/" == a.pathname.substr(0, 1) ? a.pathname :
                    "/" + a.pathname; var m = h.split("/"); 0 <= ma(d || [], m[m.length - 1]) && (m[m.length - 1] = ""); h = m.join("/"); break; case "query": h = a.search.replace("?", ""); e && (h = db(h, e, void 0)); break; case "extension": var n = a.pathname.split("."); h = 1 < n.length ? n[n.length - 1] : ""; h = h.split("/")[0]; break; case "fragment": h = a.hash.replace("#", ""); break; default: h = a && a.href
            }return h
    }, fb = function (a) { return a ? a.replace(":", "").toLowerCase() : "" }, gb = function (a) { var b = ""; if (a && a.href) { var c = a.href.indexOf("#"); b = 0 > c ? a.href : a.href.substr(0, c) } return b },
        ib = function (a) { var b = A.createElement("a"); a && (b.href = a); var c = b.pathname; "/" !== c[0] && (a || ab("TAGGING", 1), c = "/" + c); var d = b.hostname.replace(cb, ""); return { href: b.href, protocol: b.protocol, host: b.host, hostname: d, pathname: c, search: b.search, hash: b.hash, port: b.port } }; var jb = function (a, b, c) { for (var d = [], e = String(b || document.cookie).split(";"), g = 0; g < e.length; g++) { var h = e[g].split("="), k = h[0].replace(/^\s*|\s*$/g, ""); if (k && k == a) { var l = h.slice(1).join("=").replace(/^\s*|\s*$/g, ""); l && c && (l = decodeURIComponent(l)); d.push(l) } } return d }, mb = function (a, b, c, d) { var e = kb(a, d); if (1 === e.length) return e[0].id; if (0 !== e.length) { e = lb(e, function (g) { return g.Cb }, b); if (1 === e.length) return e[0].id; e = lb(e, function (g) { return g.Ua }, c); return e[0] ? e[0].id : void 0 } };
    function nb(a, b, c) { var d = document.cookie; document.cookie = a; var e = document.cookie; return d != e || void 0 != c && 0 <= jb(b, e).indexOf(c) }
    var rb = function (a, b, c, d, e, g) {
        d = d || "auto"; var h = { path: c || "/" }; e && (h.expires = e); "none" !== d && (h.domain = d); var k; a: {
            var l = b, m; if (void 0 == l) m = a + "=deleted; expires=" + (new Date(0)).toUTCString(); else { g && (l = encodeURIComponent(l)); var n = l; n && 1200 < n.length && (n = n.substring(0, 1200)); l = n; m = a + "=" + l } var q = void 0, t = void 0, p; for (p in h) if (h.hasOwnProperty(p)) {
                var r = h[p]; if (null != r) switch (p) {
                    case "secure": r && (m += "; secure"); break; case "domain": q = r; break; default: "path" == p && (t = r), "expires" == p && r instanceof Date && (r =
                        r.toUTCString()), m += "; " + p + "=" + r
                }
            } if ("auto" === q) { for (var u = ob(), w = 0; w < u.length; ++w) { var y = "none" != u[w] ? u[w] : void 0; if (!qb(y, t) && nb(m + (y ? "; domain=" + y : ""), a, l)) { k = !0; break a } } k = !1 } else q && "none" != q && (m += "; domain=" + q), k = !qb(q, t) && nb(m, a, l)
        } return k
    }; function lb(a, b, c) { for (var d = [], e = [], g, h = 0; h < a.length; h++) { var k = a[h], l = b(k); l === c ? d.push(k) : void 0 === g || l < g ? (e = [k], g = l) : l === g && e.push(k) } return 0 < d.length ? d : e }
    function kb(a, b) { for (var c = [], d = jb(a), e = 0; e < d.length; e++) { var g = d[e].split("."), h = g.shift(); if (!b || -1 !== b.indexOf(h)) { var k = g.shift(); k && (k = k.split("-"), c.push({ id: g.join("."), Cb: 1 * k[0] || 1, Ua: 1 * k[1] || 1 })) } } return c }
    var sb = /^(www\.)?google(\.com?)?(\.[a-z]{2})?$/, tb = /(^|\.)doubleclick\.net$/i, qb = function (a, b) { return tb.test(document.location.hostname) || "/" === b && sb.test(a) }, ob = function () { var a = [], b = document.location.hostname.split("."); if (4 === b.length) { var c = b[b.length - 1]; if (parseInt(c, 10).toString() === c) return ["none"] } for (var d = b.length - 2; 0 <= d; d--)a.push(b.slice(d).join(".")); a.push("none"); return a }; var Pb = [], Qb = [], Rb = [], Sb = [], Ub = [], Vb = {}, Wb, Xb, Yb, Zb = function (a, b) { var c = {}; c["function"] = "__" + a; for (var d in b) b.hasOwnProperty(d) && (c["vtp_" + d] = b[d]); return c }, $b = function (a, b) { var c = a["function"]; if (!c) throw Error("Error: No function name given for function call."); var d = !!Vb[c], e = {}, g; for (g in a) a.hasOwnProperty(g) && 0 === g.indexOf("vtp_") && (e[d ? g : g.substr(4)] = a[g]); return d ? Vb[c](e) : (void 0)(c, e, b) }, bc = function (a, b, c) { c = c || []; var d = {}, e; for (e in a) a.hasOwnProperty(e) && (d[e] = ac(a[e], b, c)); return d },
        cc = function (a) { var b = a["function"]; if (!b) throw "Error: No function name given for function call."; var c = Vb[b]; return c ? c.priorityOverride || 0 : 0 }, ac = function (a, b, c) {
            if (la(a)) {
                var d; switch (a[0]) {
                    case "function_id": return a[1]; case "list": d = []; for (var e = 1; e < a.length; e++)d.push(ac(a[e], b, c)); return d; case "macro": var g = a[1]; if (c[g]) return; var h = Pb[g]; if (!h || b.vc(h)) return; c[g] = !0; try { var k = bc(h, b, c); k.vtp_gtmEventId = b.id; d = $b(k, b); Yb && (d = Yb.pf(d, k)) } catch (w) { b.Md && b.Md(w, Number(g)), d = !1 } c[g] = !1; return d;
                    case "map": d = {}; for (var l = 1; l < a.length; l += 2)d[ac(a[l], b, c)] = ac(a[l + 1], b, c); return d; case "template": d = []; for (var m = !1, n = 1; n < a.length; n++) { var q = ac(a[n], b, c); Xb && (m = m || q === Xb.rb); d.push(q) } return Xb && m ? Xb.sf(d) : d.join(""); case "escape": d = ac(a[1], b, c); if (Xb && la(a[1]) && "macro" === a[1][0] && Xb.Uf(a)) return Xb.dg(d); d = String(d); for (var t = 2; t < a.length; t++)ub[a[t]] && (d = ub[a[t]](d)); return d; case "tag": var p = a[1]; if (!Sb[p]) throw Error("Unable to resolve tag reference " + p + "."); return d = { zd: a[2], index: p }; case "zb": var r =
                        { arg0: a[2], arg1: a[3], ignore_case: a[5] }; r["function"] = a[1]; var u = dc(r, b, c); a[4] && (u = !u); return u; default: throw Error("Attempting to expand unknown Value type: " + a[0] + ".");
                }
            } return a
        }, dc = function (a, b, c) { try { return Wb(bc(a, b, c)) } catch (d) { JSON.stringify(a) } return null }; var ec = function () { var a = function (b) { return { toString: function () { return b } } }; return { Wc: a("convert_case_to"), Xc: a("convert_false_to"), Yc: a("convert_null_to"), Zc: a("convert_true_to"), $c: a("convert_undefined_to"), fa: a("function"), Ee: a("instance_name"), Fe: a("live_only"), Ge: a("malware_disabled"), He: a("metadata"), Ng: a("original_vendor_template_id"), Ie: a("once_per_event"), pd: a("once_per_load"), qd: a("setup_tags"), rd: a("tag_id"), sd: a("teardown_tags") } }(); var fc = null, ic = function (a) { function b(q) { for (var t = 0; t < q.length; t++)d[q[t]] = !0 } var c = [], d = []; fc = gc(a); for (var e = 0; e < Qb.length; e++) { var g = Qb[e], h = hc(g); if (h) { for (var k = g.add || [], l = 0; l < k.length; l++)c[k[l]] = !0; b(g.block || []) } else null === h && b(g.block || []) } for (var m = [], n = 0; n < Sb.length; n++)c[n] && !d[n] && (m[n] = !0); return m }, hc = function (a) {
            for (var b = a["if"] || [], c = 0; c < b.length; c++) { var d = fc(b[c]); if (!d) return null === d ? null : !1 } for (var e = a.unless || [], g = 0; g < e.length; g++) {
                var h = fc(e[g]); if (null === h) return null;
                if (h) return !1
            } return !0
        }, gc = function (a) { var b = []; return function (c) { void 0 === b[c] && (b[c] = dc(Rb[c], a)); return b[c] } };/*
 Copyright (c) 2014 Derek Brans, MIT license https://github.com/krux/postscribe/blob/master/LICENSE. Portions derived from simplehtmlparser, which is licensed under the Apache License, Version 2.0 */
    var yc = {}, zc = null, Ac = Math.random(); yc.h = "UA-23581568-13"; yc.vb = "7a0"; var Bc = { __cl: !0, __ecl: !0, __ehl: !0, __evl: !0, __fal: !0, __fil: !0, __fsl: !0, __hl: !0, __jel: !0, __lcl: !0, __sdl: !0, __tl: !0, __ytl: !0 }, Cc = "www.googletagmanager.com/gtm.js"; Cc = "www.googletagmanager.com/gtag/js"; var Dc = Cc, Ec = null, Fc = null, Gc = null, Hc = "//www.googletagmanager.com/a?id=" + yc.h + "&cv=1", Ic = {}, Jc = {}, Kc = function () { var a = zc.sequence || 0; zc.sequence = a + 1; return a }; var G = function (a, b, c, d) { return (2 === Lc() || d || "http:" != v.location.protocol ? a : b) + c }, Lc = function () { var a = Na(), b; if (1 === a) a: { var c = Dc; c = c.toLowerCase(); for (var d = "https://" + c, e = "http://" + c, g = 1, h = A.getElementsByTagName("script"), k = 0; k < h.length && 100 > k; k++) { var l = h[k].src; if (l) { l = l.toLowerCase(); if (0 === l.indexOf(e)) { b = 3; break a } 1 === g && 0 === l.indexOf(d) && (g = 2) } } b = g } else b = a; return b }; var Mc = !1; var Nc = function (a, b, c, d) { if (c) { d = d || {}; var e = v._googWcmImpl || function () { e.q = e.q || []; e.q.push(arguments) }; v._googWcmImpl = e; void 0 === v._googWcmAk && (v._googWcmAk = a); Mc ? d.Aa && D(d.Aa) : (Ma(G("https://", "http://", "www.gstatic.com/wcm/loader.js"), d.Aa, d.Pd), Mc = !0); var g = { ak: a, cl: b }; void 0 === d.de && (g.autoreplace = c); e(2, d.de, g, c, 0, new Date, d.Ig) } };
    var Qc = function () { return "&tc=" + Sb.filter(function (a) { return a }).length }, Zc = function () { Rc && (v.clearTimeout(Rc), Rc = void 0); void 0 === Sc || Tc[Sc] && !Uc || (Vc[Sc] || Wc.Wf() || 0 >= Xc-- ? (ab("GTM", 1), Vc[Sc] = !0) : (Wc.og(), Pa(Yc()), Tc[Sc] = !0, Uc = "")) }, Yc = function () { var a = Sc; if (void 0 === a) return ""; var b = bb("GTM"), c = bb("TAGGING"); return [$c, Tc[a] ? "" : "&es=1", ad[a], b ? "&u=" + b : "", c ? "&ut=" + c : "", Qc(), Uc, "&z=0"].join("") }, bd = function () { return [Hc, "&v=3&t=t", "&pid=" + oa(), "&rv=" + yc.vb].join("") }, cd = "0.005000" >
        Math.random(), $c = bd(), dd = function () { $c = bd() }, Tc = {}, Uc = "", Sc = void 0, ad = {}, Vc = {}, Rc = void 0, Wc = function (a, b) { var c = 0, d = 0; return { Wf: function () { if (c < a) return !1; xa() - d >= b && (c = 0); return c >= a }, og: function () { xa() - d >= b && (c = 0); c++; d = xa() } } }(2, 1E3), Xc = 1E3, ed = function (a, b) { if (cd && !Vc[a] && Sc !== a) { Zc(); Sc = a; Uc = ""; var c; c = 0 === b.indexOf("gtm.") ? encodeURIComponent(b) : "*"; ad[a] = "&e=" + c + "&eid=" + a; Rc || (Rc = v.setTimeout(Zc, 500)) } }, fd = function (a, b, c) {
            if (cd && !Vc[a] && b) {
            a !== Sc && (Zc(), Sc = a); var d = String(b[ec.fa] || "").replace(/_/g,
                ""); 0 === d.indexOf("cvt") && (d = "cvt"); var e = c + d; Uc = Uc ? Uc + "." + e : "&tr=" + e; Rc || (Rc = v.setTimeout(Zc, 500)); 2022 <= Yc().length && Zc()
            }
        }; var gd = {}, hd = new pa, id = {}, jd = {}, nd = { name: "dataLayer", set: function (a, b) { f(kd(a, b), id); ld() }, get: function (a) { return md(a, 2) }, reset: function () { hd = new pa; id = {}; ld() } }, md = function (a, b) { if (2 != b) { var c = hd.get(a); if (cd) { var d = od(a); c !== d && ab("GTM", 5) } return c } return od(a) }, od = function (a, b, c) {
            var d = a.split("."), e = !1, g = void 0; var h = function (k, l) { for (var m = 0; void 0 !== k && m < d.length; m++) { if (null === k) return !1; k = k[d[m]] } return void 0 !== k || 1 < m ? k : l.length ? h(pd(l.pop()), l) : qd(d) };
            e = !0; g = h(id.eventModel, [b, c]); return e ? g : qd(d)
        }, qd = function (a) { for (var b = id, c = 0; c < a.length; c++) { if (null === b) return !1; if (void 0 === b) break; b = b[a[c]] } return b };
    var rd = function (a, b) { return od(a, b, void 0) }, pd = function (a) { if (a) { var b = qd(["gtag", "targets", a]); return Ha(b) ? b : void 0 } }, sd = function (a, b) { function c(g) { g && sa(g, function (h) { d[h] = null }) } var d = {}; c(id); delete d.eventModel; c(pd(a)); c(pd(b)); c(id.eventModel); var e = []; sa(d, function (g) { e.push(g) }); return e };
    var td = function (a, b) { jd.hasOwnProperty(a) || (hd.set(a, b), f(kd(a, b), id), ld()) }, kd = function (a, b) { for (var c = {}, d = c, e = a.split("."), g = 0; g < e.length - 1; g++)d = d[e[g]] = {}; d[e[e.length - 1]] = b; return c }, ld = function (a) { sa(jd, function (b, c) { hd.set(b, c); f(kd(b, void 0), id); f(kd(b, c), id); a && delete jd[b] }) }, ud = function (a, b, c) { gd[a] = gd[a] || {}; var d = 1 !== c ? od(b) : hd.get(b); "array" === Fa(d) || "object" === Fa(d) ? gd[a][b] = f(d) : gd[a][b] = d }, vd = function (a, b) { if (gd[a]) return gd[a][b] }; var wd = new RegExp(/^(.*\.)?(google|youtube|blogger|withgoogle)(\.com?)?(\.[a-z]{2})?\.?$/), xd = { cl: ["ecl"], customPixels: ["nonGooglePixels"], ecl: ["cl"], ehl: ["hl"], hl: ["ehl"], html: ["customScripts", "customPixels", "nonGooglePixels", "nonGoogleScripts", "nonGoogleIframes"], customScripts: ["html", "customPixels", "nonGooglePixels", "nonGoogleScripts", "nonGoogleIframes"], nonGooglePixels: [], nonGoogleScripts: ["nonGooglePixels"], nonGoogleIframes: ["nonGooglePixels"] }, yd = {
        cl: ["ecl"], customPixels: ["customScripts", "html"],
        ecl: ["cl"], ehl: ["hl"], hl: ["ehl"], html: ["customScripts"], customScripts: ["html"], nonGooglePixels: ["customPixels", "customScripts", "html", "nonGoogleScripts", "nonGoogleIframes"], nonGoogleScripts: ["customScripts", "html"], nonGoogleIframes: ["customScripts", "html", "nonGoogleScripts"]
    }, zd = "google customPixels customScripts html nonGooglePixels nonGoogleScripts nonGoogleIframes".split(" ");
    var Bd = function (a) {
        var b = md("gtm.whitelist"); b && ab("GTM", 9); b = "google gtagfl lcl zone oid op".split(" "); var c = b && Da(va(b), xd), d = md("gtm.blacklist"); d || (d = md("tagTypeBlacklist")) && ab("GTM", 3);
        d ? ab("GTM", 8) : d = []; Ad() && (d = va(d), d.push("nonGooglePixels", "nonGoogleScripts")); 0 <= ma(va(d), "google") && ab("GTM", 2); var e = d && Da(va(d), yd), g = {}; return function (h) {
            var k = h && h[ec.fa]; if (!k || "string" != typeof k) return !0; k = k.replace(/^_*/, ""); if (void 0 !== g[k]) return g[k]; var l = Jc[k] || [], m = a(k); if (b) {
                var n; if (n = m) a: {
                    if (0 > ma(c, k)) if (l && 0 < l.length) for (var q = 0; q < l.length; q++) {
                        if (0 >
                            ma(c, l[q])) { ab("GTM", 11); n = !1; break a }
                    } else { n = !1; break a } n = !0
                } m = n
            } var t = !1; if (d) { var p = 0 <= ma(e, k); if (p) t = p; else { var r = ra(e, l || []); r && ab("GTM", 10); t = r } } var u = !m || t; u || !(0 <= ma(l, "sandboxedScripts")) || c && -1 !== ma(c, "sandboxedScripts") || (u = ra(e, zd)); return g[k] = u
        }
    }, Ad = function () { return wd.test(v.location && v.location.hostname) }; var Cd = { pf: function (a, b) { b[ec.Wc] && "string" === typeof a && (a = 1 == b[ec.Wc] ? a.toLowerCase() : a.toUpperCase()); b.hasOwnProperty(ec.Yc) && null === a && (a = b[ec.Yc]); b.hasOwnProperty(ec.$c) && void 0 === a && (a = b[ec.$c]); b.hasOwnProperty(ec.Zc) && !0 === a && (a = b[ec.Zc]); b.hasOwnProperty(ec.Xc) && !1 === a && (a = b[ec.Xc]); return a } }; var Dd = { active: !0, isWhitelisted: function () { return !0 } }, Ed = function (a) { var b = zc.zones; !b && a && (b = zc.zones = a()); return b }; var Fd = !1, Gd = 0, Hd = []; function Id(a) { if (!Fd) { var b = A.createEventObject, c = "complete" == A.readyState, d = "interactive" == A.readyState; if (!a || "readystatechange" != a.type || c || !b && d) { Fd = !0; for (var e = 0; e < Hd.length; e++)D(Hd[e]) } Hd.push = function () { for (var g = 0; g < arguments.length; g++)D(arguments[g]); return 0 } } } function Jd() { if (!Fd && 140 > Gd) { Gd++; try { A.documentElement.doScroll("left"), Id() } catch (a) { v.setTimeout(Jd, 50) } } } var Kd = function (a) { Fd ? a() : Hd.push(a) }; var Ld = {}, Md = {}, Nd = function (a, b, c, d) { if (!Md[a] || Bc[b] || "__zone" === b) return -1; var e = {}; Ha(d) && (e = f(d, e)); e.id = c; e.status = "timeout"; return Md[a].tags.push(e) - 1 }, Od = function (a, b, c, d) { if (Md[a]) { var e = Md[a].tags[b]; e && (e.status = c, e.executionTime = d) } }; function Pd(a) { for (var b = Ld[a] || [], c = 0; c < b.length; c++)b[c](); Ld[a] = { push: function (d) { d(yc.h, Md[a]) } } }
    var Sd = function (a, b, c) { Md[a] = { tags: [] }; ia(b) && Qd(a, b); c && v.setTimeout(function () { return Pd(a) }, Number(c)); return Rd(a) }, Qd = function (a, b) { Ld[a] = Ld[a] || []; Ld[a].push(za(function () { return D(function () { b(yc.h, Md[a]) }) })) }; function Rd(a) { var b = 0, c = 0, d = !1; return { add: function () { c++; return za(function () { b++; d && b >= c && Pd(a) }) }, We: function () { d = !0; b >= c && Pd(a) } } }; var Td = function () { function a(d) { return !ka(d) || 0 > d ? 0 : d } if (!zc._li && v.performance && v.performance.timing) { var b = v.performance.timing.navigationStart, c = ka(nd.get("gtm.start")) ? nd.get("gtm.start") : 0; zc._li = { cst: a(c - b), cbt: a(Fc - b) } } }; var Xd = !1, Yd = function () { return v.GoogleAnalyticsObject && v[v.GoogleAnalyticsObject] }, Zd = !1;
    var $d = function (a) { v.GoogleAnalyticsObject || (v.GoogleAnalyticsObject = a || "ga"); var b = v.GoogleAnalyticsObject; if (v[b]) v.hasOwnProperty(b) || ab("GTM", 12); else { var c = function () { c.q = c.q || []; c.q.push(arguments) }; c.l = Number(new Date); v[b] = c } Td(); return v[b] }, ae = function (a, b, c, d) { b = String(b).replace(/\s+/g, "").split(","); var e = Yd(); e(a + "require", "linker"); e(a + "linker:autoLink", b, c, d) };
    var ce = function () { }, be = function () { return v.GoogleAnalyticsObject || "ga" }, de = !1;
    var ee = function (a, b, c) { if (b) { c = c || {}; var d = v._gaPhoneImpl || function () { d.q = d.q || []; d.q.push(arguments) }; v._gaPhoneImpl = d; void 0 === v.ga_wpid && (v.ga_wpid = a); de ? c.Aa && D(c.Aa) : (Ma(G("https://", "http://", "www.gstatic.com/gaphone/loader.js"), c.Aa, c.Pd), de = !0); var e = {}; void 0 !== c.Cd ? e.receiver = c.Cd : e.replace = b; e.ga_wpid = a; e.destination = b; d(2, new Date, e) } }; var ke = function (a) { }; function je(a, b) { a.containerId = yc.h; var c = { type: "GENERIC", value: a }; b.length && (c.trace = b); return c }; function le(a, b, c, d) { var e = Sb[a], g = me(a, b, c, d); if (!g) return null; var h = ac(e[ec.qd], c, []); if (h && h.length) { var k = h[0]; g = le(k.index, { J: g, O: 1 === k.zd ? b.terminate : g, terminate: b.terminate }, c, d) } return g }
    function me(a, b, c, d) {
        function e() {
            if (g[ec.Ge]) k(); else {
                var w = bc(g, c, []), y = Nd(c.id, String(g[ec.fa]), Number(g[ec.rd]), w[ec.He]), x = !1; w.vtp_gtmOnSuccess = function () { if (!x) { x = !0; var B = xa() - C; fd(c.id, Sb[a], "5"); Od(c.id, y, "success", B); h() } }; w.vtp_gtmOnFailure = function () { if (!x) { x = !0; var B = xa() - C; fd(c.id, Sb[a], "6"); Od(c.id, y, "failure", B); k() } }; w.vtp_gtmTagId = g.tag_id;
                w.vtp_gtmEventId = c.id; fd(c.id, g, "1"); var z = function (B) { var E = xa() - C; ke(B); fd(c.id, g, "7"); Od(c.id, y, "exception", E); x || (x = !0, k()) }; var C = xa(); try { $b(w, c) } catch (B) { z(B) }
            }
        } var g = Sb[a], h = b.J, k = b.O, l = b.terminate; if (c.vc(g)) return null; var m = ac(g[ec.sd], c, []); if (m && m.length) { var n = m[0], q = le(n.index, { J: h, O: k, terminate: l }, c, d); if (!q) return null; h = q; k = 2 === n.zd ? l : q } if (g[ec.pd] || g[ec.Ie]) { var t = g[ec.pd] ? Ub : c.zg, p = h, r = k; if (!t[a]) { e = za(e); var u = ne(a, t, e); h = u.J; k = u.O } return function () { t[a](p, r) } } return e
    }
    function ne(a, b, c) { var d = [], e = []; b[a] = oe(d, e, c); return { J: function () { b[a] = pe; for (var g = 0; g < d.length; g++)d[g]() }, O: function () { b[a] = qe; for (var g = 0; g < e.length; g++)e[g]() } } } function oe(a, b, c) { return function (d, e) { a.push(d); b.push(e); c() } } function pe(a) { a() } function qe(a, b) { b() }; var te = function (a, b) { for (var c = [], d = 0; d < Sb.length; d++)if (a.Ta[d]) { var e = Sb[d]; var g = b.add(); try { var h = le(d, { J: g, O: g, terminate: g }, a, d); h ? c.push({ be: d, Ud: cc(e), Af: h }) : (re(d, a), g()) } catch (l) { g() } } b.We(); c.sort(se); for (var k = 0; k < c.length; k++)c[k].Af(); return 0 < c.length }; function se(a, b) { var c, d = b.Ud, e = a.Ud; c = d > e ? 1 : d < e ? -1 : 0; var g; if (0 !== c) g = c; else { var h = a.be, k = b.be; g = h > k ? 1 : h < k ? -1 : 0 } return g }
    function re(a, b) { if (!cd) return; var c = function (d) { var e = b.vc(Sb[d]) ? "3" : "4", g = ac(Sb[d][ec.qd], b, []); g && g.length && c(g[0].index); fd(b.id, Sb[d], e); var h = ac(Sb[d][ec.sd], b, []); h && h.length && c(h[0].index) }; c(a); }
    var ue = !1, ve = function (a, b, c, d, e) {
        if ("gtm.js" == b) { if (ue) return !1; ue = !0 } ed(a, b); var g = Sd(a, d, e); ud(a, "event", 1); ud(a, "ecommerce", 1); ud(a, "gtm"); var h = { id: a, name: b, vc: Bd(c), Ta: [], zg: [], Md: function (n) { ab("GTM", 6); ke(n) } }; h.Ta = ic(h); var k = te(h, g); "gtm.js" !== b && "gtm.sync" !== b || ce(); if (!k) return k; for (var l = 0; l < h.Ta.length; l++)if (h.Ta[l]) {
            var m =
                Sb[l]; if (m && !Bc[String(m[ec.fa])]) return !0
        } return !1
    }; var we = function (a, b) { var c = Zb(a, b); Sb.push(c); return Sb.length - 1 }; var H = { Rb: "event_callback", Tb: "event_timeout" };
    H.ca = "gtag.config", H.Pb = "page_view", H.ee = "user_engagement", H.T = "allow_ad_personalization_signals", H.fe = "allow_custom_scripts", H.he = "allow_display_features", H.ie = "allow_enhanced_conversions", H.eb = "client_id", H.N = "cookie_domain", H.V = "cookie_expires", H.fb = "cookie_name", H.oa = "cookie_path", H.ke = "cookie_update", H.qa = "currency", H.gb = "custom_params", H.ne = "custom_map", H.Vb = "groups", H.Ia = "language", H.me = "country", H.Mg = "non_interaction", H.mb = "page_location", H.nb = "page_referrer", H.ld = "page_title", H.Ka = "send_page_view",
        H.ra = "send_to", H.ob = "session_duration", H.$b = "session_engaged", H.pb = "session_id", H.ac = "session_number", H.Ce = "tracking_id", H.qb = "user_properties", H.Ja = "linker", H.jb = "accept_incoming", H.I = "domains", H.lb = "url_position", H.kb = "decorate_forms", H.Zb = "phone_conversion_number", H.Xb = "phone_conversion_callback", H.Yb = "phone_conversion_css_class", H.md = "phone_conversion_options", H.ad = "aw_remarketing", H.bd = "aw_remarketing_only", H.da = "value", H.Ae = "quantity", H.qe = "affiliation", H.ve = "tax", H.ue = "shipping", H.Qb = "list_name",
        H.kd = "checkout_step", H.jd = "checkout_option", H.se = "coupon", H.te = "promotions", H.La = "transaction_id", H.W = "user_id", H.Ha = "conversion_linker", H.Ga = "conversion_cookie_prefix", H.H = "cookie_prefix", H.U = "items", H.fd = "aw_merchant_id", H.dd = "aw_feed_country", H.ed = "aw_feed_language", H.cd = "discount", H.hd = "disable_merchant_reported_purchases", H.Wb = "new_customer", H.gd = "customer_lifetime_value", H.pe = "dc_natural_search", H.oe = "dc_custom_params", H.De = "trip_type", H.ze = "passengers", H.xe = "method", H.Be = "search_term", H.je =
        "content_type", H.ye = "optimize_id", H.we = "experiments", H.ib = "google_signals", H.Ub = "google_tld", H.hb = "ga_restrict_domain", H.Sb = "event_settings", H.nd = [H.T, H.N, H.V, H.fb, H.oa, H.H, H.gb, H.Rb, H.Sb, H.Tb, H.hb, H.ib, H.Ub, H.Vb, H.ra, H.Ka, H.ob, H.W, H.qb], H.Vc = [H.ra, H.ad, H.bd, H.gb, H.Ka, H.Ia, H.da, H.qa, H.La, H.W, H.Ha, H.Ga, H.H, H.mb, H.nb, H.Zb, H.Xb, H.Yb, H.md, H.U, H.fd, H.dd, H.ed, H.cd, H.hd, H.Wb, H.gd, H.T]; var xe = /[A-Z]+/, ye = /\s/, ze = function (a) { if (ja(a) && (a = wa(a), !ye.test(a))) { var b = a.indexOf("-"); if (!(0 > b)) { var c = a.substring(0, b); if (xe.test(c)) { for (var d = a.substring(b + 1).split("/"), e = 0; e < d.length; e++)if (!d[e]) return; return { id: a, prefix: c, containerId: c + "-" + d[0], ia: d } } } } }, Be = function (a) { for (var b = {}, c = 0; c < a.length; ++c) { var d = ze(a[c]); d && (b[d.id] = d) } Ae(b); var e = []; sa(b, function (g, h) { e.push(h) }); return e };
    function Ae(a) { var b = [], c; for (c in a) if (a.hasOwnProperty(c)) { var d = a[c]; "AW" === d.prefix && d.ia[1] && b.push(d.containerId) } for (var e = 0; e < b.length; ++e)delete a[b[e]] }; var Ce = {}; var De = null, Ee = {}, Fe = {}, Ge, He = function (a, b) { var c = { event: a }; b && (c.eventModel = f(b), b[H.Rb] && (c.eventCallback = b[H.Rb]), b[H.Tb] && (c.eventTimeout = b[H.Tb])); return c };
    var Ie = function () { De = De || !zc.gtagRegistered; zc.gtagRegistered = !0; return De }, Ke = function (a) {
        if (void 0 === Fe[a.id]) {
            var b; switch (a.prefix) { case "UA": b = we("gtagua", { trackingId: a.id }); break; case "AW": b = we("gtagaw", { conversionId: a }); break; case "DC": b = we("gtagfl", { targetId: a.id }); break; case "GF": b = we("gtaggf", { conversionId: a }); break; case "G": b = we("get", { trackingId: a.id, isAutoTag: !0 }); break; case "HA": b = we("gtagha", { conversionId: a }); break; default: return }if (!Ge) {
                var c = Zb("v", { name: "send_to", dataLayerVersion: 2 });
                Pb.push(c); Ge = ["macro", Pb.length - 1]
            } var d = { arg0: Ge, arg1: a.id, ignore_case: !1 }; d[ec.fa] = "_lc"; Rb.push(d); var e = { "if": [Rb.length - 1], add: [b] }; e["if"] && (e.add || e.block) && Qb.push(e); Fe[a.id] = b
        }
    }, Le = function (a) { sa(Ee, function (b, c) { var d = ma(c, a); 0 <= d && c.splice(d, 1) }) }, Me = za(function () { }), Ne = function (a) { if (a.containerId !== yc.h && "G" !== a.prefix) { var b; switch (a.prefix) { case "UA": b = 14; break; case "AW": b = 15; break; case "DC": b = 16; break; default: b = 17 }ab("GTM", b) } };
    var Oe = {
        config: function (a) { var b = a[2] || {}; if (2 > a.length || !ja(a[1]) || !Ha(b)) return; var c = ze(a[1]); if (!c) return; Ie() ? (Ke(c), Ne(c)) : Me(); Le(c.id); var d = c.id, e = b[H.Vb] || "default"; e = e.toString().split(","); for (var g = 0; g < e.length; g++)Ee[e[g]] = Ee[e[g]] || [], Ee[e[g]].push(d); delete b[H.Vb]; td("gtag.targets." + c.id, void 0); td("gtag.targets." + c.id, f(b)); var h = {}; h[H.ra] = c.id; return He(H.ca, h); }, event: function (a) {
            var b = a[1]; if (ja(b) && !(3 < a.length)) {
                var c;
                if (2 < a.length) { if (!Ha(a[2])) return; c = a[2] } var d = He(b, c); var e; var g = c, h = md("gtag.fields.send_to", 2); ja(h) || (h = H.ra); var k = g && g[h]; void 0 === k && (k = md(h, 2), void 0 === k && (k = "default")); if (ja(k) || la(k)) { for (var l = k.toString().replace(/\s+/g, "").split(","), m = [], n = 0; n < l.length; n++)0 <= l[n].indexOf("-") ? m.push(l[n]) : m = m.concat(Ee[l[n]] || []); e = Be(m) } else e = void 0; var q = e; if (!q) return; var t = Ie(); t || Me(); for (var p = [], r = 0; t && r < q.length; r++) { var u = q[r]; Ne(u); p.push(u.id); Ke(u) } d.eventModel =
                    d.eventModel || {}; 0 < q.length ? d.eventModel[H.ra] = p.join() : delete d.eventModel[H.ra]; return d
            }
        }, js: function (a) { if (2 == a.length && a[1].getTime) return { event: "gtm.js", "gtm.start": a[1].getTime() } }, policy: function (a) { if (3 === a.length) { var b = a[1], c = a[2]; Ce[b] || (Ce[b] = []); Ce[b].push(c) } }, set: function (a) { var b; 2 == a.length && Ha(a[1]) ? b = f(a[1]) : 3 == a.length && ja(a[1]) && (b = {}, b[a[1]] = a[2]); if (b) return b.eventModel = f(b), b.event = "gtag.set", b._clear = !0, b }
    }, Pe = { policy: !0 }; var Qe = function () { var a = !1; return a }; var Se = function (a) { return Re ? A.querySelectorAll(a) : null }, Te = function (a, b) {
        if (!Re) return null; if (Element.prototype.closest) try { return a.closest(b) } catch (e) { return null } var c = Element.prototype.matches || Element.prototype.webkitMatchesSelector || Element.prototype.mozMatchesSelector || Element.prototype.msMatchesSelector || Element.prototype.oMatchesSelector, d = a; if (!A.documentElement.contains(d)) return null; do { try { if (c.call(d, b)) return d } catch (e) { break } d = d.parentElement || d.parentNode } while (null !== d && 1 === d.nodeType);
        return null
    }, Ue = !1; if (A.querySelectorAll) try { var Ve = A.querySelectorAll(":root"); Ve && 1 == Ve.length && Ve[0] == A.documentElement && (Ue = !0) } catch (a) { } var Re = Ue; var bf = function (a) { if (af(a)) return a; this.Gg = a }; bf.prototype.Hf = function () { return this.Gg }; var af = function (a) { return !a || "object" !== Fa(a) || Ha(a) ? !1 : "getUntrustedUpdateValue" in a }; bf.prototype.getUntrustedUpdateValue = bf.prototype.Hf; var cf = !1, df = []; function ef() { if (!cf) { cf = !0; for (var a = 0; a < df.length; a++)D(df[a]) } } var ff = function (a) { cf ? D(a) : df.push(a) }; var gf = [], hf = !1, jf = function (a) { return v["dataLayer"].push(a) }, kf = function (a) { var b = zc["dataLayer"], c = b ? b.subscribers : 1, d = 0; return function () { ++d === c && a() } }, mf = function (a) {
        var b = a._clear; sa(a, function (g, h) { "_clear" !== g && (b && td(g, void 0), td(g, h)) }); Ec || (Ec = a["gtm.start"]); var c = a.event; if (!c) return !1; var d = a["gtm.uniqueEventId"]; d || (d = Kc(), a["gtm.uniqueEventId"] = d, td("gtm.uniqueEventId", d)); Gc = c; var e = lf(a);
        Gc = null; switch (c) { case "gtag.set": e && ab("GTM", 18); break; case "gtm.init": ab("GTM", 19), e && ab("GTM", 20) }return e
    }; function lf(a) { var b = a.event, c = a["gtm.uniqueEventId"], d, e = zc.zones; d = e ? e.checkState(yc.h, c) : Dd; return d.active ? ve(c, b, d.isWhitelisted, a.eventCallback, a.eventTimeout) ? !0 : !1 : !1 }
    var nf = function () {
        for (var a = !1; !hf && 0 < gf.length;) {
            hf = !0; delete id.eventModel; ld(); var b = gf.shift(); if (null != b) {
                var c = af(b); if (c) { var d = b; b = af(d) ? d.getUntrustedUpdateValue() : void 0; for (var e = ["gtm.whitelist", "gtm.blacklist", "tagTypeBlacklist"], g = 0; g < e.length; g++) { var h = e[g], k = md(h, 1); if (la(k) || Ha(k)) k = f(k); jd[h] = k } } try {
                    if (ia(b)) try { b.call(nd) } catch (u) { } else if (la(b)) {
                        var l = b; if (ja(l[0])) {
                            var m =
                                l[0].split("."), n = m.pop(), q = l.slice(1), t = md(m.join("."), 2); if (void 0 !== t && null !== t) try { t[n].apply(t, q) } catch (u) { }
                        }
                    } else { var p = b; if (p && ("[object Arguments]" == Object.prototype.toString.call(p) || Object.prototype.hasOwnProperty.call(p, "callee"))) { a: { if (b.length && ja(b[0])) { var r = Oe[b[0]]; if (r && (!c || !Pe[b[0]])) { b = r(b); break a } } b = void 0 } if (!b) { hf = !1; continue } } a = mf(b) || a }
                } finally { c && ld(!0) }
            } hf = !1
        }
        return !a
    }, of = function () { var a = nf(); try { var b = yc.h, c = v["dataLayer"].hide; if (c && void 0 !== c[b] && c.end) { c[b] = !1; var d = !0, e; for (e in c) if (c.hasOwnProperty(e) && !0 === c[e]) { d = !1; break } d && (c.end(), c.end = null) } } catch (g) { } return a }, pf = function () {
        var a = Ka("dataLayer", []), b = Ka("google_tag_manager", {}); b = b["dataLayer"] = b["dataLayer"] || {}; Kd(function () { b.gtmDom || (b.gtmDom = !0, a.push({ event: "gtm.dom" })) }); ff(function () { b.gtmLoad || (b.gtmLoad = !0, a.push({ event: "gtm.load" })) }); b.subscribers = (b.subscribers ||
            0) + 1; var c = a.push; a.push = function () { var d; if (0 < zc.SANDBOXED_JS_SEMAPHORE) { d = []; for (var e = 0; e < arguments.length; e++)d[e] = new bf(arguments[e]) } else d = [].slice.call(arguments, 0); var g = c.apply(a, d); gf.push.apply(gf, d); if (300 < this.length) for (ab("GTM", 4); 300 < this.length;)this.shift(); var h = "boolean" !== typeof g || g; return nf() && h }; gf.push.apply(gf, a.slice(0)); D(of)
    }; var qf; var Mf = {}; Mf.rb = new String("undefined");
    var Nf = function (a) { this.resolve = function (b) { for (var c = [], d = 0; d < a.length; d++)c.push(a[d] === Mf.rb ? b : a[d]); return c.join("") } }; Nf.prototype.toString = function () { return this.resolve("undefined") }; Nf.prototype.valueOf = Nf.prototype.toString; Mf.Je = Nf; Mf.cc = {}; Mf.sf = function (a) { return new Nf(a) }; var Of = {}; Mf.pg = function (a, b) { var c = Kc(); Of[c] = [a, b]; return c }; Mf.xd = function (a) { var b = a ? 0 : 1; return function (c) { var d = Of[c]; if (d && "function" === typeof d[b]) d[b](); Of[c] = void 0 } }; Mf.Uf = function (a) {
        for (var b = !1, c = !1,
            d = 2; d < a.length; d++)b = b || 8 === a[d], c = c || 16 === a[d]; return b && c
    }; Mf.dg = function (a) { if (a === Mf.rb) return a; var b = Kc(); Mf.cc[b] = a; return 'google_tag_manager["' + yc.h + '"].macro(' + b + ")" }; Mf.Yf = function (a, b, c) { a instanceof Mf.Je && (a = a.resolve(Mf.pg(b, c)), b = ha); return { sc: a, J: b } }; var Pf = function (a, b, c) {
        function d(g, h) { var k = g[h]; return k } var e = { event: b, "gtm.element": a, "gtm.elementClasses": d(a, "className"), "gtm.elementId": a["for"] || Ua(a, "id") || "", "gtm.elementTarget": a.formTarget || d(a, "target") || "" }; c && (e["gtm.triggers"] = c.join(",")); e["gtm.elementUrl"] = (a.attributes && a.attributes.formaction ? a.formAction : "") || a.action || d(a, "href") || a.src || a.code || a.codebase ||
            ""; return e
    }, Qf = function (a) { zc.hasOwnProperty("autoEventsSettings") || (zc.autoEventsSettings = {}); var b = zc.autoEventsSettings; b.hasOwnProperty(a) || (b[a] = {}); return b[a] }, Rf = function (a, b, c) { Qf(a)[b] = c }, Sf = function (a, b, c, d) { var e = Qf(a), g = ya(e, b, d); e[b] = c(g) }, Tf = function (a, b, c) { var d = Qf(a); return ya(d, b, c) }; var Uf = function () { for (var a = Ia.userAgent + (A.cookie || "") + (A.referrer || ""), b = a.length, c = v.history.length; 0 < c;)a += c-- ^ b++; var d = 1, e, g, h; if (a) for (d = 0, g = a.length - 1; 0 <= g; g--)h = a.charCodeAt(g), d = (d << 6 & 268435455) + h + (h << 14), e = d & 266338304, d = 0 != e ? d ^ e >> 21 : d; return [Math.round(2147483647 * Math.random()) ^ d & 2147483647, Math.round(xa() / 1E3)].join(".") }, Xf = function (a, b, c, d) { var e = Vf(b); return mb(a, e, Wf(c), d) }, Vf = function (a) { if (!a) return 1; a = 0 === a.indexOf(".") ? a.substr(1) : a; return a.split(".").length }, Wf = function (a) {
        if (!a ||
            "/" === a) return 1; "/" !== a[0] && (a = "/" + a); "/" !== a[a.length - 1] && (a += "/"); return a.split("/").length - 1
    }; function Yf(a, b) { var c = "" + Vf(a), d = Wf(b); 1 < d && (c += "-" + d); return c }; var Zf = ["1"], $f = {}, dg = function (a, b, c, d) { var e = ag(a); $f[e] || bg(e, b, c) || (cg(e, Uf(), b, c, d), bg(e, b, c)) }; function cg(a, b, c, d, e) { var g; g = ["1", Yf(d, c), b].join("."); rb(a, g, c, d, 0 == e ? void 0 : new Date(xa() + 1E3 * (void 0 == e ? 7776E3 : e))) } function bg(a, b, c) { var d = Xf(a, b, c, Zf); d && ($f[a] = d); return d } function ag(a) { return (a || "_gcl") + "_au" }; var eg = function () { for (var a = [], b = A.cookie.split(";"), c = /^\s*_gac_(UA-\d+-\d+)=\s*(.+?)\s*$/, d = 0; d < b.length; d++) { var e = b[d].match(c); e && a.push({ Pc: e[1], value: e[2] }) } var g = {}; if (!a || !a.length) return g; for (var h = 0; h < a.length; h++) { var k = a[h].value.split("."); "1" == k[0] && 3 == k.length && k[1] && (g[a[h].Pc] || (g[a[h].Pc] = []), g[a[h].Pc].push({ timestamp: k[1], Ef: k[2] })) } return g }; function fg() { for (var a = gg, b = {}, c = 0; c < a.length; ++c)b[a[c]] = c; return b } function hg() { var a = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; a += a.toLowerCase() + "0123456789-_"; return a + "." }
    var gg, ig, jg = function (a) { gg = gg || hg(); ig = ig || fg(); for (var b = [], c = 0; c < a.length; c += 3) { var d = c + 1 < a.length, e = c + 2 < a.length, g = a.charCodeAt(c), h = d ? a.charCodeAt(c + 1) : 0, k = e ? a.charCodeAt(c + 2) : 0, l = g >> 2, m = (g & 3) << 4 | h >> 4, n = (h & 15) << 2 | k >> 6, q = k & 63; e || (q = 64, d || (n = 64)); b.push(gg[l], gg[m], gg[n], gg[q]) } return b.join("") }, kg = function (a) {
        function b(l) { for (; d < a.length;) { var m = a.charAt(d++), n = ig[m]; if (null != n) return n; if (!/^[\s\xa0]*$/.test(m)) throw Error("Unknown base64 encoding at char: " + m); } return l } gg = gg || hg(); ig = ig ||
            fg(); for (var c = "", d = 0; ;) { var e = b(-1), g = b(0), h = b(64), k = b(64); if (64 === k && -1 === e) return c; c += String.fromCharCode(e << 2 | g >> 4); 64 != h && (c += String.fromCharCode(g << 4 & 240 | h >> 2), 64 != k && (c += String.fromCharCode(h << 6 & 192 | k))) }
    }; var lg; function mg(a, b) { if (!a || b === A.location.hostname) return !1; for (var c = 0; c < a.length; c++)if (a[c] instanceof RegExp) { if (a[c].test(b)) return !0 } else if (0 <= b.indexOf(a[c])) return !0; return !1 }
    var qg = function () { var a = ng, b = og, c = pg(), d = function (h) { a(h.target || h.srcElement || {}) }, e = function (h) { b(h.target || h.srcElement || {}) }; if (!c.init) { Qa(A, "mousedown", d); Qa(A, "keyup", d); Qa(A, "submit", e); var g = HTMLFormElement.prototype.submit; HTMLFormElement.prototype.submit = function () { b(this); g.call(this) }; c.init = !0 } }, pg = function () { var a = Ka("google_tag_data", {}), b = a.gl; b && b.decorators || (b = { decorators: [] }, a.gl = b); return b }; var rg = /(.*?)\*(.*?)\*(.*)/, sg = /^https?:\/\/([^\/]*?)\.?cdn\.ampproject\.org\/?(.*)/, tg = /^(?:www\.|m\.|amp\.)+/, ug = /([^?#]+)(\?[^#]*)?(#.*)?/, vg = /(.*?)(^|&)_gl=([^&]*)&?(.*)/, xg = function (a) { var b = [], c; for (c in a) if (a.hasOwnProperty(c)) { var d = a[c]; void 0 !== d && d === d && null !== d && "[object Object]" !== d.toString() && (b.push(c), b.push(jg(String(d)))) } var e = b.join("*"); return ["1", wg(e), e].join("*") }, wg = function (a, b) {
        var c = [window.navigator.userAgent, (new Date).getTimezoneOffset(), window.navigator.userLanguage ||
            window.navigator.language, Math.floor((new Date).getTime() / 60 / 1E3) - (void 0 === b ? 0 : b), a].join("*"), d; if (!(d = lg)) { for (var e = Array(256), g = 0; 256 > g; g++) { for (var h = g, k = 0; 8 > k; k++)h = h & 1 ? h >>> 1 ^ 3988292384 : h >>> 1; e[g] = h } d = e } lg = d; for (var l = 4294967295, m = 0; m < c.length; m++)l = l >>> 8 ^ lg[(l ^ c.charCodeAt(m)) & 255]; return ((l ^ -1) >>> 0).toString(36)
    }, zg = function () {
        return function (a) {
            var b = ib(v.location.href), c = b.search.replace("?", ""), d = db(c, "_gl", !0) || ""; a.query = yg(d) || {}; var e = hb(b, "fragment").match(vg); a.fragment = yg(e && e[3] ||
                "") || {}
        }
    }, yg = function (a) { var b; b = void 0 === b ? 3 : b; try { if (a) { var c; a: { for (var d = a, e = 0; 3 > e; ++e) { var g = rg.exec(d); if (g) { c = g; break a } d = decodeURIComponent(d) } c = void 0 } var h = c; if (h && "1" === h[1]) { var k = h[3], l; a: { for (var m = h[2], n = 0; n < b; ++n)if (m === wg(k, n)) { l = !0; break a } l = !1 } if (l) { for (var q = {}, t = k ? k.split("*") : [], p = 0; p < t.length; p += 2)q[t[p]] = kg(t[p + 1]); return q } } } } catch (r) { } };
    function Ag(a, b, c) { function d(m) { var n = m, q = vg.exec(n), t = n; if (q) { var p = q[2], r = q[4]; t = q[1]; r && (t = t + p + r) } m = t; var u = m.charAt(m.length - 1); m && "&" !== u && (m += "&"); return m + l } c = void 0 === c ? !1 : c; var e = ug.exec(b); if (!e) return ""; var g = e[1], h = e[2] || "", k = e[3] || "", l = "_gl=" + a; c ? k = "#" + d(k.substring(1)) : h = "?" + d(h.substring(1)); return "" + g + h + k }
    function Bg(a, b, c) {
        for (var d = {}, e = {}, g = pg().decorators, h = 0; h < g.length; ++h) { var k = g[h]; (!c || k.forms) && mg(k.domains, b) && (k.fragment ? Aa(e, k.callback()) : Aa(d, k.callback())) } if (Ba(d)) {
            var l = xg(d); if (c) {
                if (a && a.action) {
                    var m = (a.method || "").toLowerCase(); if ("get" === m) {
                        for (var n = a.childNodes || [], q = !1, t = 0; t < n.length; t++) { var p = n[t]; if ("_gl" === p.name) { p.setAttribute("value", l); q = !0; break } } if (!q) {
                            var r = A.createElement("input"); r.setAttribute("type", "hidden"); r.setAttribute("name", "_gl"); r.setAttribute("value",
                                l); a.appendChild(r)
                        }
                    } else if ("post" === m) { var u = Ag(l, a.action); Za.test(u) && (a.action = u) }
                }
            } else Cg(l, a, !1)
        } if (!c && Ba(e)) { var w = xg(e); Cg(w, a, !0) }
    } function Cg(a, b, c) { if (b.href) { var d = Ag(a, b.href, void 0 === c ? !1 : c); Za.test(d) && (b.href = d) } }
    var ng = function (a) { try { var b; a: { for (var c = a, d = 100; c && 0 < d;) { if (c.href && c.nodeName.match(/^a(?:rea)?$/i)) { b = c; break a } c = c.parentNode; d-- } b = null } var e = b; if (e) { var g = e.protocol; "http:" !== g && "https:" !== g || Bg(e, e.hostname, !1) } } catch (h) { } }, og = function (a) { try { if (a.action) { var b = hb(ib(a.action), "host"); Bg(a, b, !0) } } catch (c) { } }, Dg = function (a, b, c, d) { qg(); var e = { callback: a, domains: b, fragment: "fragment" === c, forms: !!d }; pg().decorators.push(e) }, Eg = function () {
        var a = A.location.hostname, b = sg.exec(A.referrer); if (!b) return !1;
        var c = b[2], d = b[1], e = ""; if (c) { var g = c.split("/"), h = g[1]; e = "s" === h ? decodeURIComponent(g[2]) : decodeURIComponent(h) } else if (d) { if (0 === d.indexOf("xn--")) return !1; e = d.replace(/-/g, ".").replace(/\.\./g, "-") } return a.replace(tg, "") === e.replace(tg, "")
    }, Fg = function (a, b) { return !1 === a ? !1 : a || b || Eg() }; var Gg = {}; var Hg = /^\w+$/, Ig = /^[\w-]+$/, Jg = /^~?[\w-]+$/, Kg = { aw: "_aw", dc: "_dc", gf: "_gf", ha: "_ha" }; function Lg(a) { return a && "string" == typeof a && a.match(Hg) ? a : "_gcl" } var Ng = function () { var a = ib(v.location.href), b = hb(a, "query", !1, void 0, "gclid"), c = hb(a, "query", !1, void 0, "gclsrc"), d = hb(a, "query", !1, void 0, "dclid"); if (!b || !c) { var e = a.hash.replace("#", ""); b = b || db(e, "gclid", void 0); c = c || db(e, "gclsrc", void 0) } return Mg(b, c, d) };
    function Mg(a, b, c) { var d = {}, e = function (g, h) { d[h] || (d[h] = []); d[h].push(g) }; if (void 0 !== a && a.match(Ig)) switch (b) { case void 0: e(a, "aw"); break; case "aw.ds": e(a, "aw"); e(a, "dc"); break; case "ds": e(a, "dc"); break; case "3p.ds": (void 0 == Gg.gtm_3pds ? 0 : Gg.gtm_3pds) && e(a, "dc"); break; case "gf": e(a, "gf"); break; case "ha": e(a, "ha") }c && e(c, "dc"); return d }
    function Og(a, b, c) { function d(q, t) { var p = Pg(q, e); p && rb(p, t, h, g, l, !0) } b = b || {}; var e = Lg(b.prefix), g = b.domain || "auto", h = b.path || "/", k = void 0 == b.Nd ? 7776E3 : b.Nd; c = c || xa(); var l = 0 == k ? void 0 : new Date(c + 1E3 * k), m = Math.round(c / 1E3), n = function (q) { return ["GCL", m, q].join(".") }; a.aw && (!0 === b.mh ? d("aw", n("~" + a.aw[0])) : d("aw", n(a.aw[0]))); a.dc && d("dc", n(a.dc[0])); a.gf && d("gf", n(a.gf[0])); a.ha && d("ha", n(a.ha[0])) }
    var Pg = function (a, b) { var c = Kg[a]; if (void 0 !== c) return b + c }, Qg = function (a) { var b = a.split("."); return 3 !== b.length || "GCL" !== b[0] ? 0 : 1E3 * (Number(b[1]) || 0) }; function Rg(a) { var b = a.split("."); if (3 == b.length && "GCL" == b[0] && b[1]) return b[2] }
    var Sg = function (a, b, c, d, e) { if (la(b)) { var g = Lg(e); Dg(function () { for (var h = {}, k = 0; k < a.length; ++k) { var l = Pg(a[k], g); if (l) { var m = jb(l, A.cookie); m.length && (h[l] = m.sort()[m.length - 1]) } } return h }, b, c, d) } }, Tg = function (a) { return a.filter(function (b) { return Jg.test(b) }) }, Ug = function (a) { for (var b = ["aw", "dc"], c = Lg(a && a.prefix), d = {}, e = 0; e < b.length; e++)Kg[b[e]] && (d[b[e]] = Kg[b[e]]); sa(d, function (g, h) { var k = jb(c + h, A.cookie); if (k.length) { var l = k[0], m = Qg(l), n = {}; n[g] = [Rg(l)]; Og(n, a, m) } }) }; var Vg = /^\d+\.fls\.doubleclick\.net$/; function Wg(a) { var b = ib(v.location.href), c = hb(b, "host", !1); if (c && c.match(Vg)) { var d = hb(b, "path").split(a + "="); if (1 < d.length) return d[1].split(";")[0].split("?")[0] } }
    function Xg(a, b) { if ("aw" == a || "dc" == a) { var c = Wg("gcl" + a); if (c) return c.split(".") } var d = Lg(b); if ("_gcl" == d) { var e; e = Ng()[a] || []; if (0 < e.length) return e } var g = Pg(a, d), h; if (g) { var k = []; if (A.cookie) { var l = jb(g, A.cookie); if (l && 0 != l.length) { for (var m = 0; m < l.length; m++) { var n = Rg(l[m]); n && -1 === ma(k, n) && k.push(n) } h = Tg(k) } else h = k } else h = k } else h = []; return h }
    var Yg = function () { var a = Wg("gac"); if (a) return decodeURIComponent(a); var b = eg(), c = []; sa(b, function (d, e) { for (var g = [], h = 0; h < e.length; h++)g.push(e[h].Ef); g = Tg(g); g.length && c.push(d + ":" + g.join(",")) }); return c.join(";") }, $g = function (a, b, c, d, e) {
        dg(b, c, d, e); var g = $f[ag(b)], h = Ng().dc || [], k = !1; if (g && 0 < h.length) {
            var l = zc.joined_au = zc.joined_au || {}, m = b || "_gcl"; if (!l[m]) for (var n = 0; n < h.length; n++) {
                var q = "https://adservice.google.com/ddm/regclk", t = q = q + "?gclid=" + h[n] + "&auiddc=" + g; Ia.sendBeacon && Ia.sendBeacon(t) || Pa(t); k = l[m] =
                    !0
            }
        } null == a && (a = k); if (a && g) { var p = ag(b), r = $f[p]; r && cg(p, r, c, d, e) }
    }; var ah; if (3 === yc.vb.length) ah = "g"; else { var bh = "G"; bh = "g"; ah = bh }
    var ch = { "": "n", UA: "u", AW: "a", DC: "d", G: "e", GF: "f", HA: "h", GTM: ah, OPT: "o" }, dh = function (a) {
        var b = yc.h.split("-"), c = b[0].toUpperCase(), d = ch[c] || "i", e = a && "GTM" === c ? b[1] : "OPT" === c ? b[1] : "", g; if (3 === yc.vb.length) { var h = void 0; h = h || (Qe() ? "s" : "o"); g = "2" + (h || "w") } else g =
            ""; return g + d + yc.vb + e
    };
    var eh = function (a) { return !(void 0 === a || null === a || 0 === (a + "").length) }, fh = function (a, b) { var c; if (2 === b.M) return a("ord", oa(1E11, 1E13)), !0; if (3 === b.M) return a("ord", "1"), a("num", oa(1E11, 1E13)), !0; if (4 === b.M) return eh(b.sessionId) && a("ord", b.sessionId), !0; if (5 === b.M) c = "1"; else if (6 === b.M) c = b.Kc; else return !1; eh(c) && a("qty", c); eh(b.yb) && a("cost", b.yb); eh(b.transactionId) && a("ord", b.transactionId); return !0 }, gh = encodeURIComponent, hh = function (a, b) {
        function c(n, q, t) {
            g.hasOwnProperty(n) || (q += "", e += ";" + n + "=" +
                (t ? q : gh(q)))
        } var d = a.nc, e = a.protocol; e += a.Ib ? "//" + d + ".fls.doubleclick.net/activityi" : "//ad.doubleclick.net/activity"; e += ";src=" + gh(d) + (";type=" + gh(a.qc)) + (";cat=" + gh(a.Oa)); var g = a.uf || {}; sa(g, function (n, q) { e += ";" + gh(n) + "=" + gh(q + "") }); if (fh(c, a)) {
        eh(a.Nb) && c("u", a.Nb); eh(a.Mb) && c("tran", a.Mb); c("gtm", dh()); !1 === a.Se && c("npa", "1"); if (a.kc) {
            var h = Xg("dc", a.wa); h && h.length && c("gcldc", h.join(".")); var k = Xg("aw", a.wa); k && k.length && c("gclaw", k.join(".")); var l = Yg(); l && c("gac", l); dg(a.wa, void 0, a.qf, a.rf);
            var m = $f[ag(a.wa)]; m && c("auiddc", m)
        } eh(a.Gc) && c("prd", a.Gc, !0); sa(a.Rc, function (n, q) { c(n, q) }); e += b || ""; eh(a.Gb) && c("~oref", a.Gb); a.Ib ? Oa(e + "?", a.J) : Pa(e + "?", a.J, a.O)
        } else D(a.O)
    }; var ih = ["input", "select", "textarea"], jh = ["button", "hidden", "image", "reset", "submit"], kh = function (a) { var b = a.tagName.toLowerCase(); return !na(ih, function (c) { return c === b }) || "input" === b && na(jh, function (c) { return c === a.type.toLowerCase() }) ? !1 : !0 }, lh = function (a) { return a.form ? a.form.tagName ? a.form : A.getElementById(a.form) : Xa(a, ["form"], 100) }, mh = function (a, b, c) {
        if (!a.elements) return 0; for (var d = b.getAttribute(c), e = 0, g = 1; e < a.elements.length; e++) {
            var h = a.elements[e]; if (kh(h)) {
                if (h.getAttribute(c) === d) return g;
                g++
            }
        } return 0
    }; var oh = function (a) { var b = "/pagead/conversion/" + nh(a.conversion_id) + "/?", c = nh(JSON.stringify(a.conversion_data)), d = "https://www.googletraveladservices.com/travel/flights/clk" + b + "conversion_data=" + c; if (a.conversionLinkerEnabled) { var e = Xg("gf", a.cookiePrefix); if (e && e.length) for (var g = 0; g < e.length; g++)d += "&gclgf=" + nh(e[g]) } Pa(d, a.onSuccess, a.onFailure) }, nh = function (a) { return null === a || void 0 === a || 0 === String(a).length ? "" : encodeURIComponent(String(a)) };
    var ph = !!v.MutationObserver, qh = void 0, rh = function (a) { if (!qh) { var b = function () { var c = A.body; if (c) if (ph) (new MutationObserver(function () { for (var e = 0; e < qh.length; e++)D(qh[e]) })).observe(c, { childList: !0, subtree: !0 }); else { var d = !1; Qa(c, "DOMNodeInserted", function () { d || (d = !0, D(function () { d = !1; for (var e = 0; e < qh.length; e++)D(qh[e]) })) }) } }; qh = []; A.body ? b() : D(b) } qh.push(a) }; var Th = v.clearTimeout, Uh = v.setTimeout, K = function (a, b, c) { if (Qe()) { b && D(b) } else return Ma(a, b, c) }, Vh = function () { return new Date }, Wh = function () { return v.location.href }, Xh = function (a) { return hb(ib(a), "fragment") }, Yh = function (a) { return gb(ib(a)) }, Zh = null;
    var $h = function (a, b) { return md(a, b || 2) }, ai = function (a, b, c) { b && (a.eventCallback = b, c && (a.eventTimeout = c)); return jf(a) }, bi = function (a, b) { v[a] = b }, L = function (a, b, c) { b && (void 0 === v[a] || c && !v[a]) && (v[a] = b); return v[a] }, ci = function (a, b, c) { return jb(a, b, void 0 === c ? !0 : !!c) }, di = function (a, b, c, d) { var e = { prefix: a, path: b, domain: c, Nd: d }, g = Ng(); Og(g, e); Ug(e) }, ei = function (a, b, c, d, e) {
        var g = zg(), h = pg(); h.data || (h.data = { query: {}, fragment: {} }, g(h.data)); var k = {}, l = h.data; l &&
            (Aa(k, l.query), Aa(k, l.fragment)); for (var m = Lg(b), n = 0; n < a.length; ++n) { var q = a[n]; if (void 0 !== Kg[q]) { var t = Pg(q, m), p = k[t]; if (p) { var r = Math.min(Qg(p), xa()), u; b: { for (var w = r, y = jb(t, A.cookie), x = 0; x < y.length; ++x)if (Qg(y[x]) > w) { u = !0; break b } u = !1 } u || rb(t, p, c, d, 0 == e ? void 0 : new Date(r + 1E3 * (null == e ? 7776E3 : e)), !0) } } } var z = { prefix: b, path: c, domain: d }; Og(Mg(k.gclid, k.gclsrc), z);
    }, fi = function (a, b, c, d, e) { Sg(a, b, c, d, e); },
        gi = function (a, b) { if (Qe()) { b && D(b) } else Oa(a, b) }, hi = function (a) { return !!Tf(a, "init", !1) }, ii = function (a) { Rf(a, "init", !0) }, ji = function (a, b, c) { var d = (void 0 === c ? 0 : c) ? "www.googletagmanager.com/gtag/js" : Dc; d += "?id=" + encodeURIComponent(a) + "&l=dataLayer"; b && sa(b, function (e, g) { g && (d += "&" + e + "=" + encodeURIComponent(g)) }); K(G("https://", "http://", d)) }, ki = function (a, b) { var c = a[b]; return c };
    var li = function (a, b, c, d, e, g) { var h = { config: a, gtm: dh() }; c && (dg(d, void 0, e, g), h.auiddc = $f[ag(d)]); b && (h.loadInsecure = b); L("__dc_ns_processor", []).push(h); K((b ? "http" : "https") + "://www.googletagmanager.com/dclk/ns/v1.js") };
    var mi = Mf.Yf; var ni = new pa, oi = function (a, b) { function c(h) { var k = ib(h), l = hb(k, "protocol"), m = hb(k, "host", !0), n = hb(k, "port"), q = hb(k, "path").toLowerCase().replace(/\/$/, ""); if (void 0 === l || "http" == l && "80" == n || "https" == l && "443" == n) l = "web", n = "default"; return [l, m, n, q] } for (var d = c(String(a)), e = c(String(b)), g = 0; g < d.length; g++)if (d[g] !== e[g]) return !1; return !0 }, pi = function (a) {
        var b = a.arg0, c = a.arg1; if (a.any_of && la(c)) { for (var d = 0; d < c.length; d++)if (pi({ "function": a["function"], arg0: b, arg1: c[d] })) return !0; return !1 } switch (a["function"]) {
            case "_cn": return 0 <=
                String(b).indexOf(String(c)); case "_css": var e; a: { if (b) { var g = ["matches", "webkitMatchesSelector", "mozMatchesSelector", "msMatchesSelector", "oMatchesSelector"]; try { for (var h = 0; h < g.length; h++)if (b[g[h]]) { e = b[g[h]](c); break a } } catch (u) { } } e = !1 } return e; case "_ew": var k, l; k = String(b); l = String(c); var m = k.length - l.length; return 0 <= m && k.indexOf(l, m) == m; case "_eq": return String(b) == String(c); case "_ge": return Number(b) >= Number(c); case "_gt": return Number(b) > Number(c); case "_lc": var n; n = String(b).split(",");
                return 0 <= ma(n, String(c)); case "_le": return Number(b) <= Number(c); case "_lt": return Number(b) < Number(c); case "_re": var q; var t = a.ignore_case ? "i" : void 0; try { var p = String(c) + t, r = ni.get(p); r || (r = new RegExp(c, t), ni.set(p, r)); q = r.test(b) } catch (u) { q = !1 } return q; case "_sw": return 0 == String(b).indexOf(String(c)); case "_um": return oi(b, c)
        }return !1
    }; var ri = function (a, b) { var c = function () { }; c.prototype = a.prototype; var d = new c; a.apply(d, Array.prototype.slice.call(arguments, 1)); return d }; var si = {}, ti = encodeURI, Y = encodeURIComponent, ui = Pa; var vi = function (a, b) { if (!a) return !1; var c = hb(ib(a), "host"); if (!c) return !1; for (var d = 0; b && d < b.length; d++) { var e = b[d] && b[d].toLowerCase(); if (e) { var g = c.length - e.length; 0 < g && "." != e.charAt(0) && (g-- , e = "." + e); if (0 <= g && c.indexOf(e, g) == g) return !0 } } return !1 };
    var wi = function (a, b, c) { for (var d = {}, e = !1, g = 0; a && g < a.length; g++)a[g] && a[g].hasOwnProperty(b) && a[g].hasOwnProperty(c) && (d[a[g][b]] = a[g][c], e = !0); return e ? d : null }; si.Vf = function () { var a = !1; return a }; var xi = function () { var a = !1; return a }; var Xi = function () { var a = v.gaGlobal = v.gaGlobal || {}; a.hid = a.hid || oa(); return a.hid }; var oj = function (a, b, c, d) { this.n = a; this.t = b; this.p = c; this.d = d }, pj = function () { this.c = 1; this.e = []; this.p = null }; function qj(a) { var b = zc, c = b.gss = b.gss || {}; return c[a] = c[a] || new pj } var rj = function (a, b) { qj(a).p = b }, sj = function (a) { var b = qj(a), c = b.p; if (c) { var d = b.e, e = []; b.e = []; var g = function (h) { for (var k = 0; k < h.length; k++)try { var l = h[k]; l.d ? (l.d = !1, e.push(l)) : c(l.n, l.t, l.p) } catch (m) { } }; g(d); g(e) } }; var Cj = window, Dj = document, Ej = function (a) { var b = Cj._gaUserPrefs; if (b && b.ioo && b.ioo() || a && !0 === Cj["ga-disable-" + a]) return !0; try { var c = Cj.external; if (c && c._gaUserPrefs && "oo" == c._gaUserPrefs) return !0 } catch (g) { } for (var d = jb("AMP_TOKEN", Dj.cookie, !0), e = 0; e < d.length; e++)if ("$OPT_OUT" == d[e]) return !0; return Dj.getElementById("__gaOptOutExtension") ? !0 : !1 }; var Lj = function (a, b, c) { Kj(a); var d = Math.floor(xa() / 1E3); qj(a).e.push(new oj(b, d, c, void 0)); sj(a) }, Mj = function (a, b, c) { Kj(a); var d = Math.floor(xa() / 1E3); qj(a).e.push(new oj(b, d, c, !0)) }, Kj = function (a) { if (1 === qj(a).c && (qj(a).c = 2, !Qe())) { var b = encodeURIComponent(a); Ma(("http:" != v.location.protocol ? "https:" : "http:") + ("//www.googletagmanager.com/gtag/js?id=" + b + "&l=dataLayer&cx=c")) } }, Oj = function (a, b) { }, Nj = function (a,
        b) { }, Pj = function (a) { return "_" === a.charAt(0) }, Qj = function (a) { sa(a, function (c) { Pj(c) && delete a[c] }); var b = a[H.qb] || {}; sa(b, function (c) { Pj(c) && delete b[c] }) }; var Z = { a: {} };

    Z.a.gtagha = ["google"], function () {
        function a(h) { function k(m, n) { void 0 !== n && l.push(m + "=" + n) } if (void 0 === h) return ""; var l = []; k("hct_base_price", h.Fd); k("hct_booking_xref", h.Gd); k("hct_checkin_date", h.Kf); k("hct_checkout_date", h.Lf); k("hct_currency_code", h.Mf); k("hct_partner_hotel_id", h.Hd); k("hct_total_price", h.Id); return l.join(";") } function b(h, k, l, m) {
            var n = Y(h), q = Y(a(k)), t = "https://www.googletraveladservices.com/travel/clk/pagead/conversion/" + n + "/?data=" + q; l && (t += Xg("ha", m).map(function (p) {
                return "&gclha=" +
                    Y(p)
            }).join("")); return t
        } function c(h, k, l, m, n, q) { /^\d+$/.test(h) ? ui(b(h, k, l, m), n, q) : D(q) } function d(h, k, l, m) { var n = {}; ja(h) ? n.Gd = h : "number" === typeof h && (n.Gd = String(h)); ja(l) && (n.Mf = l); ja(k) ? n.Id = n.Fd = k : "number" === typeof k && (n.Id = n.Fd = String(k)); if (!la(m) || 0 == m.length) return n; var q = m[0]; if (!Ha(q)) return n; ja(q.id) ? n.Hd = q.id : "number" === typeof q.id && (n.Hd = String(q.id)); ja(q.start_date) && (n.Kf = q.start_date); ja(q.end_date) && (n.Lf = q.end_date); return n } function e(h) {
            var k = Gc, l = h.vtp_gtmOnSuccess, m = h.vtp_gtmOnFailure,
            n = h.vtp_conversionId, q = n.containerId, t = function (z) { return od(z, q, n.id) }, p = !1 !== t(H.Ha), r = t(H.Ga) || t(H.H), u = t(H.N), w = t(H.V); if (k === H.ca) { var y = t(H.Ja) || {}; p && (Fg(y[H.jb], !!y[H.I]) && ei(g, r, void 0, u, w), di(r, void 0, u, w)); y[H.I] && fi(g, y[H.I], y[H.lb], !!y[H.kb], r); D(l) } else if ("purchase" === k) { var x = d(t(H.La), t(H.da), t(H.qa), t(H.U)); c(n.ia[0], x, p, r, l, m) } else D(m)
        } var g = ["ha"]; Z.__gtagha = e; Z.__gtagha.b = "gtagha"; Z.__gtagha.g = !0; Z.__gtagha.priorityOverride = 0;
    }();
    Z.a.e = ["google"], function () { (function (a) { Z.__e = a; Z.__e.b = "e"; Z.__e.g = !0; Z.__e.priorityOverride = 0 })(function (a) { return String(vd(a.vtp_gtmEventId, "event")) }) }();


    Z.a.v = ["google"], function () { (function (a) { Z.__v = a; Z.__v.b = "v"; Z.__v.g = !0; Z.__v.priorityOverride = 0 })(function (a) { var b = a.vtp_name; if (!b || !b.replace) return !1; var c = $h(b.replace(/\\\./g, "."), a.vtp_dataLayerVersion || 1); return void 0 !== c ? c : a.vtp_defaultValue }) }();





    Z.a.gtagaw = ["google"], function () {
        var a = !1, b = [], c = ["aw", "dc"], d = function (m) { var n = L("google_trackConversion"), q = m.gtm_onFailure; "function" == typeof n ? n(m) || q() : q() }, e = function () { for (; 0 < b.length;)d(b.shift()) }, g = function () { a || (a = !0, Td(), K(G("https://", "http://", "www.googleadservices.com/pagead/conversion_async.js"), function () { e(); b = { push: d } }, function () { e(); a = !1 })) }, h = function (m, n, q, t) {
            if (Qe()) { } else {
            la(n) || (n = [n]); for (var p =
                0; p < n.length; p++)1 > p && Nc(m.ia[0], m.ia[1], n[p], { de: q, Ig: t })
            }
        }, k = function (m) { if (m) { for (var n = [], q = 0; q < m.length; ++q) { var t = m[q]; t && n.push({ item_id: t.id, quantity: t.quantity, value: t.price, start_date: t.start_date, end_date: t.end_date }) } return n } }, l = function (m) {
            var n = m.vtp_conversionId, q = Gc, t = q == H.ca, p = n.ia[0], r = n.ia[1], u = void 0 !== r, w = n.containerId, y = u ? n.id : void 0, x = function (X) { return od(X, w, y) }, z = !1 !== x(H.Ha), C = x(H.Ga) || x(H.H), B = x(H.N), E = x(H.V); if (t) {
                var F = x(H.Ja) || {}; z && (Fg(F[H.jb], !!F[H.I]) && ei(c, C, void 0,
                    B, E), di(C, void 0, B, E)); F[H.I] && fi(c, F[H.I], F[H.lb], !!F[H.kb], C); if (u) { var P = x(H.Zb), U = x(H.Xb), R = x(H.Yb), T = x(H.md); h(n, P, U || R, T) }
            } var O = !1 === x(H.ad) || !1 === x(H.Ka); if (!t || !u && !O) if (!0 === x(H.bd) && (u = !1), !1 !== x(H.T) || u) {
                var M = {
                    google_conversion_id: p, google_remarketing_only: !u, onload_callback: m.vtp_gtmOnSuccess, gtm_onFailure: m.vtp_gtmOnFailure, google_conversion_format: "3", google_conversion_color: "ffffff", google_conversion_domain: "", google_conversion_label: r, google_conversion_language: x(H.Ia), google_conversion_value: x(H.da),
                    google_conversion_currency: x(H.qa), google_conversion_order_id: x(H.La), google_user_id: x(H.W), google_conversion_page_url: x(H.mb), google_conversion_referrer_url: x(H.nb), google_gtm: dh()
                }; Qe() && (M.opt_image_generator = function () { return new Image }, M.google_enable_display_cookie_match = !1); !1 === x(H.T) && (M.google_allow_ad_personalization_signals = !1); M.google_read_gcl_cookie_opt_out = !z; z && C && (M.google_gcl_cookie_prefix = C); var I = function () {
                    var X = x(H.gb), W = { event: q }; if (la(X)) {
                        for (var ea = 0; ea < X.length; ++ea) {
                            var V =
                                X[ea], N = x(V); void 0 !== N && (W[V] = N)
                        } return W
                    } var aa = x("eventModel"); if (!aa) return null; f(aa, W); for (var qa = 0; qa < H.Vc.length; ++qa)delete W[H.Vc[qa]]; return W
                }(); I && (M.google_custom_params = I); !u && x(H.U) && (M.google_gtag_event_data = { items: x(H.U), value: x(H.da) }); if (u && "purchase" == q) {
                M.google_conversion_merchant_id = x(H.fd); M.google_basket_feed_country = x(H.dd); M.google_basket_feed_language = x(H.ed); M.google_basket_discount = x(H.cd); M.google_basket_transaction_type = q; M.google_disable_merchant_reported_conversions =
                    !0 === x(H.hd); Qe() && (M.google_disable_merchant_reported_conversions = !0); var J = k(x(H.U)); J && (M.google_conversion_items = J)
                } var Q = function (X, W) { void 0 != W && "" !== W && (M.google_additional_conversion_params = M.google_additional_conversion_params || {}, M.google_additional_conversion_params[X] = W) }; u && ("boolean" == typeof x(H.Wb) && Q("vdnc", x(H.Wb)), Q("vdltv", x(H.gd))); var S = !0;
                S && b.push(M)
            } g()
        }; Z.__gtagaw = l; Z.__gtagaw.b = "gtagaw"; Z.__gtagaw.g = !0; Z.__gtagaw.priorityOverride = 0
    }();


    Z.a.get = ["google"], function () {
        (function (a) { Z.__get = a; Z.__get.b = "get"; Z.__get.g = !0; Z.__get.priorityOverride = 0 })(function (a) {
            if (a.vtp_isAutoTag) { for (var b = String(a.vtp_trackingId), c = Gc || "", d = {}, e = H.nd, g = 0; g < e.length; g++) { var h = rd(e[g], b); void 0 !== h && (d[e[g]] = h) } var k = rd(H.gb, b); if (la(k)) for (var l = 0; l < k.length; l++) { var m = k[l], n = rd(m, b); void 0 !== n && (d[m] = n) } else { var q = $h("eventModel"); f(q, d) } if (Pj(c)) return; Qj(d); Lj(b, c, f(d)) } else {
                var t = a.vtp_settings, p = t.eventParameters, r = t.userProperties; f(wi(a.vtp_eventParameters,
                    "name", "value"), p); f(wi(a.vtp_userProperties, "name", "value"), r); p[H.qb] = r; var u = String(a.vtp_eventName), w = a.vtp_allowSystemNames; if (!w && Pj(u)) return; w || Qj(p); (a.vtp_deferrable ? Mj : Lj)(String(t.streamId), u, p)
            } a.vtp_gtmOnSuccess()
        })
    }();


    Z.a.gtagfl = [], function () {
        function a(e) { var g = /^DC-(\d+)(\/([\w-]+)\/([\w-]+)\+(\w+))?$/.exec(e); if (g) { var h = { standard: 2, unique: 3, per_session: 4, transactions: 5, items_sold: 6, "": 1 }[(g[5] || "").toLowerCase()]; if (h) return { containerId: "DC-" + g[1], ce: g[3] ? e : "", Me: g[1], Le: g[3] || "", Oa: g[4] || "", M: h } } } function b(e, g) {
            function h(t, p, r) { void 0 !== r && 0 !== (r + "").length && k.push(t + p + ":" + e(r + "")) } var k = [], l = g(H.U) || []; if (la(l)) for (var m = 0; m < l.length; m++) {
                var n = l[m], q = m + 1; h("i", q, n.id); h("p", q, n.price); h("q", q, n.quantity);
                h("c", q, g(H.me)); h("l", q, g(H.Ia))
            } return k.join("|")
        } function c(e, g, h) { var k = /^u([1-9]\d?|100)$/, l = e(H.ne) || {}, m = sd(g, h), n = {}, q = {}; if (Ha(l)) for (var t in l) if (l.hasOwnProperty(t) && k.test(t)) { var p = l[t]; ja(p) && (n[t] = p) } for (var r = 0; r < m.length; r++) { var u = m[r]; k.test(u) && (n[u] = u) } for (var w in n) n.hasOwnProperty(w) && (q[w] = e(n[w])); return q } var d = ["aw", "dc"]; (function (e) { Z.__gtagfl = e; Z.__gtagfl.b = "gtagfl"; Z.__gtagfl.g = !0; Z.__gtagfl.priorityOverride = 0 })(function (e) {
            var g = e.vtp_gtmOnSuccess, h = e.vtp_gtmOnFailure,
            k = a(e.vtp_targetId); if (k) {
                var l = function (R) { return od(R, k.containerId, k.ce || void 0) }, m = !1 !== l(H.Ha), n = l(H.Ga) || l(H.H), q = l(H.N), t = l(H.V), p = l(H.pe), r = 3 === Lc(); if (Gc === H.ca) { var u = l(H.Ja) || {}, w = l(H.ke), y = void 0 === w ? !0 : !!w; m && (Fg(u[H.jb], !!u[H.I]) && ei(d, n, void 0, q, t), di(n, void 0, q, t), $g(y, n, void 0, q, t)); u[H.I] && fi(d, u[H.I], u[H.lb], !!u[H.kb], n); p && p.exclusion_parameters && p.engines && li(p, r, m, n, q, t); D(g) } else {
                    var x = {}, z = l(H.oe); if (Ha(z)) for (var C in z) if (z.hasOwnProperty(C)) {
                        var B = z[C]; void 0 !== B && null !==
                            B && (x[C] = B)
                    } var E = ""; if (5 === k.M || 6 === k.M) E = b(Y, l); var F = c(l, k.containerId, k.ce), P = !0 === l(H.fe); if (Qe() && P) { P = !1 } var U = { Oa: k.Oa, kc: m, qf: q, rf: t, wa: n, yb: l(H.da), M: k.M, uf: x, nc: k.Me, qc: k.Le, O: h, J: g, Gb: Yh(Wh()), Gc: E, protocol: r ? "http:" : "https:", Kc: l(H.Ae), Ib: P, sessionId: l(H.pb), Mb: void 0, transactionId: l(H.La), Nb: void 0, Rc: F, Se: !1 !== l(H.T) }; hh(U)
                }
            } else D(h)
        })
    }();


    Z.a.gtaggf = ["google"], function () {
        var a = /.*\.google\.com(:\d+)?\/booking\/flights.*/, b = function (c) { if (c) { for (var d = [], e = 0, g = 0; g < c.length; ++g) { var h = c[g]; !h || void 0 !== h.category && "" !== h.category && "FlightSegment" !== h.category || (d[e] = { cabin: h.travel_class, fare_product: h.fare_product, booking_code: h.booking_code, flight_number: h.flight_number, origin: h.origin, destination: h.destination, departure_date: h.start_date }, e++) } return d } }; (function (c) {
        Z.__gtaggf = c; Z.__gtaggf.b = "gtaggf"; Z.__gtaggf.g = !0; Z.__gtaggf.priorityOverride =
            0
        })(function (c) {
            var d = Gc, e = c.vtp_gtmOnSuccess, g = c.vtp_gtmOnFailure, h = c.vtp_conversionId, k = h.ia[0], l = h.containerId, m = function (x) { return od(x, l, h.id) }, n = !1 !== m(H.Ha), q = m(H.Ga) || m(H.H), t = m(H.N), p = m(H.V); if (d === H.ca) n && di(q, void 0, t, p), D(e); else {
                var r = { conversion_id: k, onFailure: g, onSuccess: e, conversionLinkerEnabled: n, cookiePrefix: q }; if ("purchase" === d) {
                    var u = a.test(Wh()), w = { partner_id: k, trip_type: m(H.De), total_price: m(H.da), currency: m(H.qa), is_direct_booking: u, flight_segment: b(m(H.U)) }, y = m(H.ze); y && "object" ===
                        typeof y && (w.passengers_total = y.total, w.passengers_adult = y.adult, w.passengers_child = y.child, w.passengers_infant_in_seat = y.infant_in_seat, w.passengers_infant_in_lap = y.infant_in_lap); r.conversion_data = w
                } oh(r)
            }
        })
    }();




    Z.a.gtagua = ["google"], function () {
        var a, b = { client_id: 1, client_storage: "storage", cookie_name: 1, cookie_domain: 1, cookie_expires: 1, cookie_path: 1, cookie_update: 1, sample_rate: 1, site_speed_sample_rate: 1, use_amp_client_id: 1, store_gac: 1, conversion_linker: "storeGac" }, c = {
            anonymize_ip: 1, app_id: 1, app_installer_id: 1, app_name: 1, app_version: 1, campaign: { name: "campaignName", source: "campaignSource", medium: "campaignMedium", term: "campaignTerm", content: "campaignContent", id: "campaignId" }, currency: "currencyCode", description: "exDescription",
            fatal: "exFatal", language: 1, non_interaction: 1, page_hostname: "hostname", page_referrer: "referrer", page_path: "page", page_location: "location", page_title: "title", screen_name: 1, transport_type: "transport", user_id: 1
        }, d = { content_id: 1, event_category: 1, event_action: 1, event_label: 1, link_attribution: 1, linker: 1, method: 1, name: 1, send_page_view: 1, value: 1 }, e = { cookie_name: 1, cookie_expires: "duration", levels: 1 }, g = { anonymize_ip: 1, fatal: 1, non_interaction: 1, use_amp_client_id: 1, send_page_view: 1, store_gac: 1, conversion_linker: 1 },
        h = function (r, u, w, y) { if (void 0 !== w) if (g[u] && (w = ua(w)), "anonymize_ip" != u || w || (w = void 0), 1 === r) y[k(u)] = w; else if (ja(r)) y[r] = w; else for (var x in r) r.hasOwnProperty(x) && void 0 !== w[x] && (y[r[x]] = w[x]) }, k = function (r) { return r && ja(r) ? r.replace(/(_[a-z])/g, function (u) { return u[1].toUpperCase() }) : r }, l = function (r, u, w) { r.hasOwnProperty(u) || (r[u] = w) }, m = function (r, u, w) {
            var y = {}, x = {}, z = {}, C; var B = rd(H.we, r); if (la(B)) {
                for (var E = [], F = 0; F < B.length; F++) {
                    var P = B[F]; if (void 0 != P) {
                        var U = P.id, R = P.variant; void 0 != U && void 0 !=
                            R && E.push(String(U) + "." + String(R))
                    }
                } C = 0 < E.length ? E.join("!") : void 0
            } else C = void 0; var T = C; T && l(x, "exp", T); var O = rd("custom_map", r); if (Ha(O)) for (var M in O) if (O.hasOwnProperty(M) && /^(dimension|metric)\d+$/.test(M) && void 0 != O[M]) { var I = rd(String(O[M]), r); void 0 !== I && l(x, M, I) } for (var J = sd(r), Q = 0; Q < J.length; ++Q) {
                var S = J[Q], X = rd(S, r); d.hasOwnProperty(S) ? h(d[S], S, X, y) : c.hasOwnProperty(S) ? h(c[S], S, X, x) : b.hasOwnProperty(S) ? h(b[S], S, X, z) : /^(dimension|metric|content_group)\d+$/.test(S) ? h(1, S, X, x) : S === H.H &&
                    0 > ma(J, H.fb) && (z.cookieName = X + "_ga")
            } var W = String(Gc); l(z, "cookieDomain", "auto"); l(x, "forceSSL", !0); var ea = "general"; 0 <= ma("add_payment_info add_to_cart add_to_wishlist begin_checkout checkout_progress purchase refund remove_from_cart set_checkout_option".split(" "), W) ? ea = "ecommerce" : 0 <= ma("generate_lead login search select_content share sign_up view_item view_item_list view_promotion view_search_results".split(" "), W) ? ea = "engagement" : "exception" == W && (ea = "error"); l(y, "eventCategory", ea); 0 <= ma(["view_item",
                "view_item_list", "view_promotion", "view_search_results"], W) && l(x, "nonInteraction", !0); "login" == W || "sign_up" == W || "share" == W ? l(y, "eventLabel", rd(H.xe, r)) : "search" == W || "view_search_results" == W ? l(y, "eventLabel", rd(H.Be, r)) : "select_content" == W && l(y, "eventLabel", rd(H.je, r)); var V = y[H.Ja] || {}, N = V[H.jb]; N || 0 != N && V[H.I] ? z.allowLinker = !0 : !1 === N && l(z, "useAmpClientId", !1); if (!1 === rd(H.he, r) || !1 === rd(H.T, r)) x.allowAdFeatures = !1; z.name = u; x["&gtm"] = dh(!0); x.hitCallback = w; y.Z = x; y.mc = z; return y
        }, n = function (r) {
            function u(I) {
                var J =
                    f(I); J.list = I.list_name; J.listPosition = I.list_position; J.position = I.list_position || I.creative_slot; J.creative = I.creative_name; return J
            } function w(I) { for (var J = [], Q = 0; I && Q < I.length; Q++)I[Q] && J.push(u(I[Q])); return J.length ? J : void 0 } function y(I) { return { id: z(x.La), affiliation: z(x.qe), revenue: z(x.da), tax: z(x.ve), shipping: z(x.ue), coupon: z(x.se), list: z(x.Qb) || I } } for (var x = H, z = function (I) { return od(I, r, void 0) }, C = z(x.U), B, E = 0; C && E < C.length && !(B = C[E][x.Qb]); E++); var F = z("custom_map"); if (Ha(F)) for (var P =
                0; C && P < C.length; ++P) { var U = C[P], R; for (R in F) F.hasOwnProperty(R) && /^(dimension|metric)\d+$/.test(R) && void 0 != F[R] && l(U, R, U[F[R]]) } var T = null, O = Gc, M = z(x.te); "purchase" == O || "refund" == O ? T = { action: O, Na: y(), Ca: w(C) } : "add_to_cart" == O ? T = { action: "add", Ca: w(C) } : "remove_from_cart" == O ? T = { action: "remove", Ca: w(C) } : "view_item" == O ? T = { action: "detail", Na: y(B), Ca: w(C) } : "view_item_list" == O ? T = { action: "impressions", Pf: w(C) } : "view_promotion" == O ? T = { action: "promo_view", Hc: w(M) } : "select_content" == O && M && 0 < M.length ? T = {
                    action: "promo_click",
                    Hc: w(M)
                } : "select_content" == O ? T = { action: "click", Na: { list: z(x.Qb) || B }, Ca: w(C) } : "begin_checkout" == O || "checkout_progress" == O ? T = { action: "checkout", Ca: w(C), Na: { step: "begin_checkout" == O ? 1 : z(x.kd), option: z(x.jd) } } : "set_checkout_option" == O && (T = { action: "checkout_option", Na: { step: z(x.kd), option: z(x.jd) } }); T && (T.Tg = z(x.qa)); return T
        }, q = {}, t = function (r, u) {
            var w = q[r]; q[r] = f(u); if (!w) return !1; for (var y in u) if (u.hasOwnProperty(y) && u[y] !== w[y]) return !0; for (var x in w) if (w.hasOwnProperty(x) && w[x] !== u[x]) return !0;
            return !1
        }, p = function (r) {
            var u = r.vtp_trackingId, w = "https://www.google-analytics.com/analytics.js", y = $d(); if (ia(y)) {
                var x = "gtag_" + u.split("-").join("_"), z = function (O) { var M = [].slice.call(arguments, 0); M[0] = x + "." + M[0]; y.apply(window, M) }, C = function () {
                    var O = function (Q, S) { for (var X = 0; S && X < S.length; X++)z(Q, S[X]) }, M = n(u); if (M) {
                        var I = M.action; if ("impressions" == I) O("ec:addImpression", M.Pf); else if ("promo_click" == I || "promo_view" == I) {
                            var J = M.Hc; O("ec:addPromo", M.Hc); J && 0 < J.length && "promo_click" == I && z("ec:setAction",
                                I)
                        } else O("ec:addProduct", M.Ca), z("ec:setAction", I, M.Na)
                    }
                }, B = function () { if (Qe()) { } else { var O = rd(H.ye, u); O && (z("require", O, { dataLayer: "dataLayer" }), z("require", "render")) } }, E = function () {
                    if (Qe()) { } else {
                        var O = rd(H.Zb, u), M = rd(H.Yb, u), I = rd(H.Xb, u), J; J = la(O) ? O : [O]; for (var Q = 0; Q < J.length; Q++)5 >
                            Q && ee(u, J[Q], { Cd: I || M });
                    }
                }, F = m(u, x, r.vtp_gtmOnSuccess); (function () { })(); t(x, F.mc) && y(function () { Yd() && Yd().remove(x) }); y("create", u, F.mc); (function () {
                    var O = rd("custom_map", u); y(function () {
                        if (Ha(O)) {
                            var M = F.Z, I = Yd().getByName(x), J; for (J in O) if (O.hasOwnProperty(J) && /^(dimension|metric)\d+$/.test(J) && void 0 != O[J]) {
                                var Q = I.get(k(O[J]));
                                l(M, J, Q)
                            }
                        }
                    })
                })(); (function (O) { if (O) { var M = {}; if (Ha(O)) for (var I in e) e.hasOwnProperty(I) && h(e[I], I, O[I], M); z("require", "linkid", M) } })(F.linkAttribution); var P = F[H.Ja]; if (P && P[H.I]) { var U = P[H.lb]; ae(x + ".", P[H.I], void 0 === U ? !!P.use_anchor : "fragment" === U, !!P[H.kb]) } var R = function (O, M, I) { I && (M = "" + M); F.Z[O] = M }, T = Gc; T == H.Pb ? (B(), z("send", "pageview", F.Z)) : T == H.ca ? (B(), E(), 0 != F.sendPageView && z("send", "pageview", F.Z)) : "screen_view" == T ? z("send", "screenview", F.Z) : "timing_complete" == T ? (R("timingCategory", F.eventCategory,
                    !0), R("timingVar", F.name, !0), R("timingValue", ta(F.value)), void 0 !== F.eventLabel && R("timingLabel", F.eventLabel, !0), z("send", "timing", F.Z)) : "exception" == T ? z("send", "exception", F.Z) : "optimize.callback" != T && (0 <= ma("view_item_list select_content view_item add_to_cart remove_from_cart begin_checkout set_checkout_option purchase refund view_promotion checkout_progress".split(" "), T) && (z("require", "ec", "ec.js"), C()), R("eventCategory", F.eventCategory, !0), R("eventAction", F.eventAction || T, !0), void 0 !== F.eventLabel &&
                        R("eventLabel", F.eventLabel, !0), void 0 !== F.value && R("eventValue", ta(F.value)), z("send", "event", F.Z)); a || (a = !0, Td(), K(w, function () { Yd().loaded || r.vtp_gtmOnFailure() }, r.vtp_gtmOnFailure))
            } else D(r.vtp_gtmOnFailure)
        }; Z.__gtagua = p; Z.__gtagua.b = "gtagua"; Z.__gtagua.g = !0; Z.__gtagua.priorityOverride = 0
    }();

    var Rj = {}; Rj.macro = function (a) { if (Mf.cc.hasOwnProperty(a)) return Mf.cc[a] }, Rj.onHtmlSuccess = Mf.xd(!0), Rj.onHtmlFailure = Mf.xd(!1); Rj.dataLayer = nd; Rj.callback = function (a) { Ic.hasOwnProperty(a) && ia(Ic[a]) && Ic[a](); delete Ic[a] }; Rj.af = function () { zc[yc.h] = Rj; Aa(Jc, Z.a); Xb = Xb || Mf; Yb = Cd };
    Rj.Qf = function () {
    Gg.gtm_3pds = !0; zc = v.google_tag_manager = v.google_tag_manager || {}; if (zc[yc.h]) { var a = zc.zones; a && a.unregisterChild(yc.h) } else {
        for (var b = data.resource || {}, c = b.macros || [], d = 0; d < c.length; d++)Pb.push(c[d]); for (var e = b.tags || [], g = 0; g < e.length; g++)Sb.push(e[g]); for (var h = b.predicates || [],
            k = 0; k < h.length; k++)Rb.push(h[k]); for (var l = b.rules || [], m = 0; m < l.length; m++) { for (var n = l[m], q = {}, t = 0; t < n.length; t++)q[n[t][0]] = Array.prototype.slice.call(n[t], 1); Qb.push(q) } Vb = Z; Wb = pi; Rj.af(); pf(); Fd = !1; Gd = 0; if ("interactive" == A.readyState && !A.createEventObject || "complete" == A.readyState) Id(); else { Qa(A, "DOMContentLoaded", Id); Qa(A, "readystatechange", Id); if (A.createEventObject && A.documentElement.doScroll) { var p = !0; try { p = !v.frameElement } catch (y) { } p && Jd() } Qa(v, "load", Id) } cf = !1; "complete" === A.readyState ? ef() :
                Qa(v, "load", ef); a: { if (!cd) break a; v.setInterval(dd, 864E5); }
        Fc = (new Date).getTime();
    }
    }; (0, Rj.Qf)();

})()