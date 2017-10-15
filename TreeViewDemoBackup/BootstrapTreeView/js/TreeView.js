﻿!function (e, t, o, s) { "use strict"; var n = "treeview", i = {}; i.settings = { injectStyle: !0, levels: 2, expandIcon: "glyphicon glyphicon-plus", collapseIcon: "glyphicon glyphicon-minus", emptyIcon: "glyphicon", nodeIcon: "", selectedIcon: "", checkedIcon: "glyphicon glyphicon-check", uncheckedIcon: "glyphicon glyphicon-unchecked", color: s, backColor: s, borderColor: s, onhoverColor: "#F5F5F5", selectedColor: "#FFFFFF", selectedBackColor: "#428bca", searchResultColor: "#D9534F", searchResultBackColor: s, enableLinks: !1, highlightSelected: !0, highlightSearchResults: !0, showBorder: !1, showIcon: !0, showCheckbox: !1, showTags: !1, multiSelect: !1, onNodeChecked: s, onNodeCollapsed: s, onNodeDisabled: s, onNodeEnabled: s, onNodeExpanded: s, onNodeSelected: s, onNodeUnchecked: s, onNodeUnselected: s, onSearchComplete: s, onSearchCleared: s }, i.options = { silent: !1, ignoreChildren: !1 }, i.searchOptions = { ignoreCase: !0, exactMatch: !1, revealResults: !0 }; var d = function (t, o) { return this.$element = e(t), this.elementId = t.id, this.styleId = this.elementId + "-style", this.init(o), { options: this.options, init: e.proxy(this.init, this), remove: e.proxy(this.remove, this), getNode: e.proxy(this.getNode, this), getParent: e.proxy(this.getParent, this), getSiblings: e.proxy(this.getSiblings, this), getSelected: e.proxy(this.getSelected, this), getUnselected: e.proxy(this.getUnselected, this), getExpanded: e.proxy(this.getExpanded, this), getCollapsed: e.proxy(this.getCollapsed, this), getChecked: e.proxy(this.getChecked, this), getUnchecked: e.proxy(this.getUnchecked, this), getDisabled: e.proxy(this.getDisabled, this), getEnabled: e.proxy(this.getEnabled, this), selectNode: e.proxy(this.selectNode, this), unselectNode: e.proxy(this.unselectNode, this), toggleNodeSelected: e.proxy(this.toggleNodeSelected, this), collapseAll: e.proxy(this.collapseAll, this), collapseNode: e.proxy(this.collapseNode, this), expandAll: e.proxy(this.expandAll, this), expandNode: e.proxy(this.expandNode, this), toggleNodeExpanded: e.proxy(this.toggleNodeExpanded, this), revealNode: e.proxy(this.revealNode, this), checkAll: e.proxy(this.checkAll, this), checkNode: e.proxy(this.checkNode, this), uncheckAll: e.proxy(this.uncheckAll, this), uncheckNode: e.proxy(this.uncheckNode, this), toggleNodeChecked: e.proxy(this.toggleNodeChecked, this), disableAll: e.proxy(this.disableAll, this), disableNode: e.proxy(this.disableNode, this), enableAll: e.proxy(this.enableAll, this), enableNode: e.proxy(this.enableNode, this), toggleNodeDisabled: e.proxy(this.toggleNodeDisabled, this), search: e.proxy(this.search, this), clearSearch: e.proxy(this.clearSearch, this) } }; d.prototype.init = function (t) { this.tree = [], this.nodes = [], t.data && ("string" == typeof t.data && (t.data = e.parseJSON(t.data)), this.tree = e.extend(!0, [], t.data), delete t.data), this.options = e.extend({}, i.settings, t), this.destroy(), this.subscribeEvents(), this.setInitialStates({ nodes: this.tree }, 0), this.render() }, d.prototype.remove = function () { this.destroy(), e.removeData(this, n), e("#" + this.styleId).remove() }, d.prototype.destroy = function () { this.initialized && (this.$wrapper.remove(), this.$wrapper = null, this.unsubscribeEvents(), this.initialized = !1) }, d.prototype.unsubscribeEvents = function () { this.$element.off("click"), this.$element.off("nodeChecked"), this.$element.off("nodeCollapsed"), this.$element.off("nodeDisabled"), this.$element.off("nodeEnabled"), this.$element.off("nodeExpanded"), this.$element.off("nodeSelected"), this.$element.off("nodeUnchecked"), this.$element.off("nodeUnselected"), this.$element.off("searchComplete"), this.$element.off("searchCleared") }, d.prototype.subscribeEvents = function () { this.unsubscribeEvents(), this.$element.on("click", e.proxy(this.clickHandler, this)), "function" == typeof this.options.onNodeChecked && this.$element.on("nodeChecked", this.options.onNodeChecked), "function" == typeof this.options.onNodeCollapsed && this.$element.on("nodeCollapsed", this.options.onNodeCollapsed), "function" == typeof this.options.onNodeDisabled && this.$element.on("nodeDisabled", this.options.onNodeDisabled), "function" == typeof this.options.onNodeEnabled && this.$element.on("nodeEnabled", this.options.onNodeEnabled), "function" == typeof this.options.onNodeExpanded && this.$element.on("nodeExpanded", this.options.onNodeExpanded), "function" == typeof this.options.onNodeSelected && this.$element.on("nodeSelected", this.options.onNodeSelected), "function" == typeof this.options.onNodeUnchecked && this.$element.on("nodeUnchecked", this.options.onNodeUnchecked), "function" == typeof this.options.onNodeUnselected && this.$element.on("nodeUnselected", this.options.onNodeUnselected), "function" == typeof this.options.onSearchComplete && this.$element.on("searchComplete", this.options.onSearchComplete), "function" == typeof this.options.onSearchCleared && this.$element.on("searchCleared", this.options.onSearchCleared) }, d.prototype.setInitialStates = function (t, o) { if (t.nodes) { o += 1; var s = t, n = this; e.each(t.nodes, function (e, t) { t.nodeId = n.nodes.length, t.parentId = s.nodeId, t.hasOwnProperty("selectable") || (t.selectable = !0), t.state = t.state || {}, t.state.hasOwnProperty("checked") || (t.state.checked = !1), t.state.hasOwnProperty("disabled") || (t.state.disabled = !1), t.state.hasOwnProperty("expanded") || (!t.state.disabled && o < n.options.levels && t.nodes && t.nodes.length > 0 ? t.state.expanded = !0 : t.state.expanded = !1), t.state.hasOwnProperty("selected") || (t.state.selected = !1), n.nodes.push(t), t.nodes && n.setInitialStates(t, o) }) } }, d.prototype.clickHandler = function (t) { this.options.enableLinks || t.preventDefault(); var o = e(t.target), s = this.findNode(o); if (s && !s.state.disabled) { var n = o.attr("class") ? o.attr("class").split(" ") : []; -1 !== n.indexOf("expand-icon") ? (this.toggleExpandedState(s, i.options), this.render()) : -1 !== n.indexOf("check-icon") ? (this.toggleCheckedState(s, i.options), this.render()) : (s.selectable ? this.toggleSelectedState(s, i.options) : this.toggleExpandedState(s, i.options), this.render()) } }, d.prototype.findNode = function (e) { var t = e.closest("li.list-group-item").attr("data-nodeid"), o = this.nodes[t]; return o || console.log("Error: node does not exist"), o }, d.prototype.toggleExpandedState = function (e, t) { e && this.setExpandedState(e, !e.state.expanded, t) }, d.prototype.setExpandedState = function (t, o, s) { o !== t.state.expanded && (o && t.nodes ? (t.state.expanded = !0, s.silent || this.$element.trigger("nodeExpanded", e.extend(!0, {}, t))) : o || (t.state.expanded = !1, s.silent || this.$element.trigger("nodeCollapsed", e.extend(!0, {}, t)), t.nodes && !s.ignoreChildren && e.each(t.nodes, e.proxy(function (e, t) { this.setExpandedState(t, !1, s) }, this)))) }, d.prototype.toggleSelectedState = function (e, t) { e && this.setSelectedState(e, !e.state.selected, t) }, d.prototype.setSelectedState = function (t, o, s) { o !== t.state.selected && (o ? (this.options.multiSelect || e.each(this.findNodes("true", "g", "state.selected"), e.proxy(function (e, t) { this.setSelectedState(t, !1, s) }, this)), t.state.selected = !0, s.silent || this.$element.trigger("nodeSelected", e.extend(!0, {}, t))) : (t.state.selected = !1, s.silent || this.$element.trigger("nodeUnselected", e.extend(!0, {}, t)))) }, d.prototype.toggleCheckedState = function (e, t) { e && this.setCheckedState(e, !e.state.checked, t) }, d.prototype.setCheckedState = function (t, o, s) { o !== t.state.checked && (o ? (t.state.checked = !0, s.silent || this.$element.trigger("nodeChecked", e.extend(!0, {}, t))) : (t.state.checked = !1, s.silent || this.$element.trigger("nodeUnchecked", e.extend(!0, {}, t)))) }, d.prototype.setDisabledState = function (t, o, s) { o !== t.state.disabled && (o ? (t.state.disabled = !0, this.setExpandedState(t, !1, s), this.setSelectedState(t, !1, s), this.setCheckedState(t, !1, s), s.silent || this.$element.trigger("nodeDisabled", e.extend(!0, {}, t))) : (t.state.disabled = !1, s.silent || this.$element.trigger("nodeEnabled", e.extend(!0, {}, t)))) }, d.prototype.render = function () { this.initialized || (this.$element.addClass(n), this.$wrapper = e(this.template.list), this.injectStyle(), this.initialized = !0), this.$element.empty().append(this.$wrapper.empty()), this.buildTree(this.tree, 0) }, d.prototype.buildTree = function (t, o) { if (t) { o += 1; var s = this; e.each(t, function (t, n) { for (var i = e(s.template.item).addClass("node-" + s.elementId).addClass(n.state.checked ? "node-checked" : "").addClass(n.state.disabled ? "node-disabled" : "").addClass(n.state.selected ? "node-selected" : "").addClass(n.searchResult ? "search-result" : "").attr("data-nodeid", n.nodeId).attr("style", s.buildStyleOverride(n)), d = 0; o - 1 > d; d++) i.append(s.template.indent); var r = []; if (n.nodes ? (r.push("expand-icon"), n.state.expanded ? r.push(s.options.collapseIcon) : r.push(s.options.expandIcon)) : r.push(s.options.emptyIcon), i.append(e(s.template.icon).addClass(r.join(" "))), s.options.showIcon) { var r = ["node-icon"]; r.push(n.icon || s.options.nodeIcon), n.state.selected && (r.pop(), r.push(n.selectedIcon || s.options.selectedIcon || n.icon || s.options.nodeIcon)), i.append(e(s.template.icon).addClass(r.join(" "))) } if (s.options.showCheckbox) { var r = ["check-icon"]; n.state.checked ? r.push(s.options.checkedIcon) : r.push(s.options.uncheckedIcon), i.append(e(s.template.icon).addClass(r.join(" "))) } return s.options.enableLinks ? i.append(e(s.template.link).attr("href", n.href).append(n.text).append(e(s.template.listItemCaption).append(" (" + n.Designaton + ") "))) : i.append("<span>" + n.text + "</span>").append(e(s.template.listItemCaption).append(" (" + n.Designaton + ") ")), s.options.showTags && n.tags && e.each(n.tags, function (t, o) { i.append(e(s.template.badge).append(o)) }), s.$wrapper.append(i), n.nodes && n.state.expanded && !n.state.disabled ? s.buildTree(n.nodes, o) : void 0 }) } }, d.prototype.buildStyleOverride = function (e) { if (e.state.disabled) return ""; var t = e.color, o = e.backColor; return this.options.highlightSelected && e.state.selected && (this.options.selectedColor && (t = this.options.selectedColor), this.options.selectedBackColor && (o = this.options.selectedBackColor)), this.options.highlightSearchResults && e.searchResult && !e.state.disabled && (this.options.searchResultColor && (t = this.options.searchResultColor), this.options.searchResultBackColor && (o = this.options.searchResultBackColor)), "color:" + t + ";background-color:" + o + ";" }, d.prototype.injectStyle = function () { this.options.injectStyle && !o.getElementById(this.styleId) && e('<style type="text/css" id="' + this.styleId + '"> ' + this.buildStyle() + " </style>").appendTo("head") }, d.prototype.buildStyle = function () { var e = ".node-" + this.elementId + "{"; return this.options.color && (e += "color:" + this.options.color + ";"), this.options.backColor && (e += "background-color:" + this.options.backColor + ";"), this.options.showBorder ? this.options.borderColor && (e += "border:1px solid " + this.options.borderColor + ";") : e += "border:none;", e += "}", this.options.onhoverColor && (e += ".node-" + this.elementId + ":not(.node-disabled):hover{background-color:" + this.options.onhoverColor + ";}"), this.css + e }, d.prototype.template = { list: '<ul class="list-group"></ul>', item: '<li class="list-group-item"></li>', indent: '<span class="indent"></span>', icon: '<span class="icon"></span>', link: '<a href="#" style="color:inherit;"></a>', badge: '<span class="badge"></span>', listItemCaption: '<span class="ItemCaption"></span>' }, d.prototype.css = ".treeview .list-group-item{cursor:pointer}.treeview span.indent{margin-left:10px;margin-right:10px}.treeview span.icon{width:12px;margin-right:5px}.treeview .node-disabled{color:silver;cursor:not-allowed}", d.prototype.getNode = function (e) { return this.nodes[e] }, d.prototype.getParent = function (e) { var t = this.identifyNode(e); return this.nodes[t.parentId] }, d.prototype.getSiblings = function (e) { var t = this.identifyNode(e), o = this.getParent(t), s = o ? o.nodes : this.tree; return s.filter(function (e) { return e.nodeId !== t.nodeId }) }, d.prototype.getSelected = function () { return this.findNodes("true", "g", "state.selected") }, d.prototype.getUnselected = function () { return this.findNodes("false", "g", "state.selected") }, d.prototype.getExpanded = function () { return this.findNodes("true", "g", "state.expanded") }, d.prototype.getCollapsed = function () { return this.findNodes("false", "g", "state.expanded") }, d.prototype.getChecked = function () { return this.findNodes("true", "g", "state.checked") }, d.prototype.getUnchecked = function () { return this.findNodes("false", "g", "state.checked") }, d.prototype.getDisabled = function () { return this.findNodes("true", "g", "state.disabled") }, d.prototype.getEnabled = function () { return this.findNodes("false", "g", "state.disabled") }, d.prototype.selectNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setSelectedState(e, !0, t) }, this)), this.render() }, d.prototype.unselectNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setSelectedState(e, !1, t) }, this)), this.render() }, d.prototype.toggleNodeSelected = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.toggleSelectedState(e, t) }, this)), this.render() }, d.prototype.collapseAll = function (t) { var o = this.findNodes("true", "g", "state.expanded"); this.forEachIdentifier(o, t, e.proxy(function (e, t) { this.setExpandedState(e, !1, t) }, this)), this.render() }, d.prototype.collapseNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setExpandedState(e, !1, t) }, this)), this.render() }, d.prototype.expandAll = function (t) { if (t = e.extend({}, i.options, t), t && t.levels) this.expandLevels(this.tree, t.levels, t); else { var o = this.findNodes("false", "g", "state.expanded"); this.forEachIdentifier(o, t, e.proxy(function (e, t) { this.setExpandedState(e, !0, t) }, this)) } this.render() }, d.prototype.expandNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setExpandedState(e, !0, t), e.nodes && t && t.levels && this.expandLevels(e.nodes, t.levels - 1, t) }, this)), this.render() }, d.prototype.expandLevels = function (t, o, s) { s = e.extend({}, i.options, s), e.each(t, e.proxy(function (e, t) { this.setExpandedState(t, o > 0 ? !0 : !1, s), t.nodes && this.expandLevels(t.nodes, o - 1, s) }, this)) }, d.prototype.revealNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { for (var o = this.getParent(e) ; o;) this.setExpandedState(o, !0, t), o = this.getParent(o) }, this)), this.render() }, d.prototype.toggleNodeExpanded = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.toggleExpandedState(e, t) }, this)), this.render() }, d.prototype.checkAll = function (t) { var o = this.findNodes("false", "g", "state.checked"); this.forEachIdentifier(o, t, e.proxy(function (e, t) { this.setCheckedState(e, !0, t) }, this)), this.render() }, d.prototype.checkNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setCheckedState(e, !0, t) }, this)), this.render() }, d.prototype.uncheckAll = function (t) { var o = this.findNodes("true", "g", "state.checked"); this.forEachIdentifier(o, t, e.proxy(function (e, t) { this.setCheckedState(e, !1, t) }, this)), this.render() }, d.prototype.uncheckNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setCheckedState(e, !1, t) }, this)), this.render() }, d.prototype.toggleNodeChecked = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.toggleCheckedState(e, t) }, this)), this.render() }, d.prototype.disableAll = function (t) { var o = this.findNodes("false", "g", "state.disabled"); this.forEachIdentifier(o, t, e.proxy(function (e, t) { this.setDisabledState(e, !0, t) }, this)), this.render() }, d.prototype.disableNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setDisabledState(e, !0, t) }, this)), this.render() }, d.prototype.enableAll = function (t) { var o = this.findNodes("true", "g", "state.disabled"); this.forEachIdentifier(o, t, e.proxy(function (e, t) { this.setDisabledState(e, !1, t) }, this)), this.render() }, d.prototype.enableNode = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setDisabledState(e, !1, t) }, this)), this.render() }, d.prototype.toggleNodeDisabled = function (t, o) { this.forEachIdentifier(t, o, e.proxy(function (e, t) { this.setDisabledState(e, !e.state.disabled, t) }, this)), this.render() }, d.prototype.forEachIdentifier = function (t, o, s) { o = e.extend({}, i.options, o), t instanceof Array || (t = [t]), e.each(t, e.proxy(function (e, t) { s(this.identifyNode(t), o) }, this)) }, d.prototype.identifyNode = function (e) { return "number" == typeof e ? this.nodes[e] : e }, d.prototype.search = function (t, o) { o = e.extend({}, i.searchOptions, o), this.clearSearch({ render: !1 }); var s = []; if (t && t.length > 0) { o.exactMatch && (t = "^" + t + "$"); var n = "g"; o.ignoreCase && (n += "i"), s = this.findNodes(t, n), e.each(s, function (e, t) { t.searchResult = !0 }) } return o.revealResults ? this.revealNode(s) : this.render(), this.$element.trigger("searchComplete", e.extend(!0, {}, s)), s }, d.prototype.clearSearch = function (t) { t = e.extend({}, { render: !0 }, t); var o = e.each(this.findNodes("true", "g", "searchResult"), function (e, t) { t.searchResult = !1 }); t.render && this.render(), this.$element.trigger("searchCleared", e.extend(!0, {}, o)) }, d.prototype.findNodes = function (t, o, s) { o = o || "g", s = s || "text"; var n = this; return e.grep(this.nodes, function (e) { var i = n.getNodeValue(e, s); return "string" == typeof i ? i.match(new RegExp(t, o)) : void 0 }) }, d.prototype.getNodeValue = function (e, t) { var o = t.indexOf("."); if (o > 0) { var n = e[t.substring(0, o)], i = t.substring(o + 1, t.length); return this.getNodeValue(n, i) } return e.hasOwnProperty(t) ? e[t].toString() : s }; var r = function (e) { t.console && t.console.error(e) }; e.fn[n] = function (t, o) { var s; return this.each(function () { var i = e.data(this, n); "string" == typeof t ? i ? e.isFunction(i[t]) && "_" !== t.charAt(0) ? (o instanceof Array || (o = [o]), s = i[t].apply(i, o)) : r("No such method : " + t) : r("Not initialized, can not call method : " + t) : "boolean" == typeof t ? s = i : e.data(this, n, new d(this, e.extend(!0, {}, t))) }), s || this } }(jQuery, window, document);