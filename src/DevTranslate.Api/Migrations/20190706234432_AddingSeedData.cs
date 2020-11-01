﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace DevTranslate.Api.Migrations
{
    public partial class AddingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "translations",
                columns: new[] { "id", "author", "imageUrl", "language", "status", "title", "translator", "type", "url" },
                values: new object[,]
                {
                    { 1, "Gajus Kuizinas", "https://image.ibb.co/b9GdKb/1.png", 1, 1, "Pare de usar CSS no JavaScript para desenvolvimento web", "Carlos Eduardo Olivieri", 1, "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e" },
                    { 102, "Lua.org", "https://image.ibb.co/niEHxw/102.png", 1, 1, "Documentação de Lua 5.2", "Sérgio Queiroz de Medeiros e Roberto Ierusalimschy", 3, "https://www.lua.org/manual/5.2/pt/" },
                    { 103, "Django Software Foundation", "https://image.ibb.co/d724cw/103.png", 1, 1, "Documentação do Django", "Comunidade Django", 3, "https://docs.djangoproject.com/pt-br/1.11/" },
                    { 104, "Ray Nicholus", "https://image.ibb.co/h70CVG/104.png", 1, 1, "Você não precisa de jQuery (Não mais)", "Gabriel Ribeiro e Eric Cristhiano", 1, "https://github.com/ericdouglas/traduz-ai/tree/master/series/voce-nao-precisa-de-jquery" },
                    { 105, "Charles Scalfani", "https://image.ibb.co/ndqCVG/105.png", 1, 2, "Então você quer ser um Programador Funcional?", "Gabriel Ribeiro", 1, "https://github.com/ericdouglas/traduz-ai/tree/master/series/entao-voce-quer-ser-um-programador-funcional" },
                    { 106, "Todd Motto", "https://image.ibb.co/ieQeAG/106.png", 1, 1, "Guia Definitivo para Aprender Angularjs em 1 Dia", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/001-guia-definitivo-para-aprender-angularjs.md" },
                    { 107, "Danny Markov", "https://image.ibb.co/gcZT4b/107.png", 1, 1, "Aprenda AngularJS com 5 Exemplos", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/002-aprenda-angularjs-com-5-exemplos.md" },
                    { 108, "Year Of Moo", "https://image.ibb.co/cA1mqG/108.png", 1, 1, "Use AngularJS para Potencializar suas Aplicações Web", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/003-use-angularjs-para-potencializar-sua-webapp.md#use-angularjs-para-potencializar-suas-aplica%C3%A7%C3%B5es-web" },
                    { 101, "Facebook", "https://image.ibb.co/nyuvjb/101.png", 1, 1, "Documentação do Jest", "-", 3, "http://facebook.github.io/jest/pt-BR/" },
                    { 109, "Year Of Moo", "https://image.ibb.co/eNxRqG/109.png", 1, 1, "Mais Mágicas do AngularJS para Turbinar sua Webapp", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/004-mais-magicas-angularjs-para-turbinar-sua-webapp.md#mais-m%C3%A1gicas-do-angularjs-para-turbinar-sua-webapp" },
                    { 111, "Gajus Kuizinas", "https://image.ibb.co/etdAHw/111.png", 1, 1, "Behaviour Driven Development com JavaScript", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/bdd/001-bdd-with-js.md" },
                    { 112, "Javascript is Sexy", "https://image.ibb.co/dGbxxw/112.png", 1, 1, "Aprenda Tudo sobre Handlebars.js Templating JavaScript", "Eric Douglas e Thulio Philipe", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/handlebars/001-aprenda-tudo-sobre-handlebars.md#aprenda-tudo-sobre-handlebarsjs-templating-javascript" },
                    { 113, "Javascript is Sexy", "https://image.ibb.co/mzL1Pb/113.png", 1, 1, "Como aprender Javascript Corretamente! – JavaScript.is (Sexy)", "Eric Douglas", 1, "http://javascriptissexy.com/how-to-learn-javascript-properly/" },
                    { 114, "Javascript is Sexy", "https://image.ibb.co/ieUHxw/114.png", 1, 1, "Objetos JavaScript em Detalhe", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/002-objetos-js-em-detalhe.md#objetos-javascript-em-detalhe" },
                    { 115, "Javascript is Sexy", "https://image.ibb.co/mdjjcw/115.png", 1, 1, "Escopo e Hoisting de Variáveis no JavaScript Explicados", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/003-escopo-de-variavel-js-e-hoisting-explicado.md#escopo-de-vari%C3%A1vel-javascript-e-hoisting-explicado" },
                    { 116, "Javascript is Sexy", "https://image.ibb.co/hJycxw/116.png", 1, 1, "Entenda Closures no JavaScript com Facilidade", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/004-entenda-closures-no-javaScript-com-facilidade.md#entenda-closures-no-javascript-com-facilidade" },
                    { 117, "Javascript is Sexy", "https://image.ibb.co/fchgPb/117.png", 1, 1, "Protótipos Javascript em uma Linguagem Simples", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/005-prototipos-javascript-em-uma-linguagem-simples.md#prot%C3%B3tipos-javascript-em-uma-linguagem-simples" },
                    { 110, "AngularJS", "https://image.ibb.co/coPT4b/110.png", 1, 1, "Entendendo Diretivas", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/005-entendendo-diretivas.md" },
                    { 118, "Javascript is Sexy", "https://image.ibb.co/k1XRqG/118.png", 1, 1, "Aprenda Funções JavaScript de Ordem Superior - Funções Callback", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/006-entenda-callbacks-js.md" },
                    { 100, "Rico Sta. Cruz", "https://image.ibb.co/cR8MPb/100.png", 1, 1, "Documentação de RSCSS", "Mateus da Silva Sousa", 3, "https://silvamateus.gitbooks.io/rscss/content/" },
                    { 98, "Joomla! EDL", "https://image.ibb.co/gG5eAG/98.png", 1, 1, "Documentação do Joomla", "Comunidade Joomla", 3, "https://docs.joomla.org/Joomla_info_page/pt-BR" },
                    { 82, "Taylor Otwel", "https://image.ibb.co/fGWajb/82.png", 1, 2, "Laravel 4 Docs", "Kaio Cesar", 3, "https://github.com/kaiocesar/laravel4-docs-ptbr" },
                    { 83, "Github", "https://image.ibb.co/mp4Hxw/83.png", 1, 2, "Open Source Guides", "Fernando Moreira", 3, "https://github.com/nandomoreirame/open-source-guide" },
                    { 84, "John Washam", "https://image.ibb.co/cxR84b/84.png", 1, 2, "Google Interview University", "Marlon Aviz", 4, "https://github.com/avizmarlon/google-interview-university" },
                    { 85, "PHP Group", "https://image.ibb.co/idU6qG/85.png", 1, 2, "Guia de Edição do Manual de PHP", "Anderson Mamede, Fabio Abrantes, etc", 3, "https://github.com/phpdocbrbridge/traducao/wiki/Guia-de-edi%C3%A7%C3%A3o-do-manual" },
                    { 86, "Facebook", "https://image.ibb.co/eKdMPb/86.png", 1, 2, "Documentação React Native", "Anthony Conceição e Lorhana Trindade", 3, "https://github.com/AnthonyMRodrigues/docsreactnative" },
                    { 87, "Ruby", "https://image.ibb.co/fM8MPb/87.png", 1, 1, "Documentação - Ruby", "-", 3, "https://www.ruby-lang.org/pt/documentation/" },
                    { 88, "Yii Software LLC", "https://image.ibb.co/fzqPcw/88.png", 1, 2, "Guia Definitivo para Yii 2.0", "Davidson Alencar, Jan Silva, etc", 3, "https://github.com/yiisoft/yii2/tree/master/docs/guide-pt-BR" },
                    { 99, "Evan You", "https://image.ibb.co/iT1KAG/99.png", 1, 1, "Documentação do Vue.js", "-", 3, "https://br.vuejs.org/" },
                    { 89, "The PostgreSQL Global Development Group", "https://image.ibb.co/kcOMPb/89.png", 1, 2, "Documentação de PostgreSQL", "Comunidade do PostgreSQL", 3, "https://www.postgresql.org.br/pages/documentacao.html" },
                    { 91, "SensioLabs", "https://image.ibb.co/ftRKAG/91.png", 1, 2, "Documentação do Symfony", "Andréia Bohner", 3, "https://github.com/andreia/symfony-docs-pt-BR" },
                    { 92, "Meteor Development Group Inc.", "https://image.ibb.co/mCJo4b/92.png", 1, 1, "Documentação do Framework Meteor", "Guilherme Decampo", 3, "https://github.com/MeteorBrasil/meteor-docsbr" },
                    { 93, "Alexandre Gomes Gaigalas", "https://image.ibb.co/hUJAHw/93.png", 1, 1, "Documentação Respect / REST", "Nando Kstro, Eduardo Lopes e Eric Cristhiano", 3, "https://github.com/NandoKstroNet/docptbrrespectrest" },
                    { 94, "Mozilla", "https://image.ibb.co/dcssVG/94.png", 1, 1, "Documentação de JavaScript", "Comunidade MDN", 3, "https://developer.mozilla.org/pt-BR/docs/Web/JavaScript" },
                    { 95, "Alexandre Gomes Gaigalas", "https://image.ibb.co/mrTo4b/95.png", 1, 1, "Documentação do Respect\\Validation", "Nando Kstro", 3, "https://github.com/NandoKstroNet/docsptbrrespectvalidation" },
                    { 96, "Taylor Otwel", "https://image.ibb.co/mcoAHw/96.png", 1, 1, "Laravel Docs", "Vinicius Reis, Leandro Sanches, Hely de Sousa, etc", 3, "https://github.com/artesaos/laravel-docs" },
                    { 97, "Michael Jackson", "https://image.ibb.co/fidAHw/97.png", 1, 1, "Documentação do Framework Jasmine 2.0", "Eric Douglas", 3, "http://ericdouglas.github.io/jasmine-br-docs/" },
                    { 90, "Mark Otto e Jacob", "https://image.ibb.co/dgVeAG/90.png", 1, 1, "Documentação do Bootstrap", "-", 3, "http://getbootstrap.com.br/" },
                    { 81, "Jeff Carouth", "https://image.ibb.co/iadcxw/81.png", 1, 2, "Sabedoria do Elefante (Wisdom of the ElePHPant)", "Reginaldo Junior e Vitor Capretz", 2, "https://github.com/reginaldojunior/wisdom-of-the-elephant" },
                    { 119, "Adtile Technologies Inc.", "https://image.ibb.co/gJYo4b/119.png", 1, 1, "Um Mergulho no JavaScript Puro", "Lucas F. Costa", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/007-um-mergulho-no-javascript-puro.md" },
                    { 121, "James Sinclair", "https://image.ibb.co/mrvPcw/121.png", 1, 1, "Uma Suave Introdução ao JavaScript Funcional", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/009-uma-suave-introducao-ao-javascript-parte-1.md" },
                    { 142, "David Kopal", "https://image.ibb.co/mQOe46/142.png", 1, 1, "Vale a pena aprender Vanilla JS? Claro!", "Marina Limeira", 1, "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/vale-a-pena-aprender-vanillajs--com-certeza.md" },
                    { 143, "Matt Lunn", "https://image.ibb.co/gahxP6/143.png", 1, 1, "Tratando uma resposta AJAX em Javascript (com ou sem jQuery)", "Matheus", 1, "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/tratando-respostas-ajax-com-ou-sem-jquery.md" },
                    { 144, "Atlassian", "https://image.ibb.co/f3qR1m/144.png", 1, 1, "O que é controle de versão", "Phillip Nunes", 1, "https://github.com/entrylvl/traducoes-de-artigos/blob/master/git/o-que-e-controle-de-versao.md" },
                    { 145, "Atlassian", "https://image.ibb.co/gXgS7R/145.png", 1, 1, "O que é Git?", "Will Soares e Carolina Pascale Campos", 1, "https://github.com/entrylvl/traducoes-de-artigos/blob/master/git/o-que-e-git.md" },
                    { 146, "Timothy B. Smith", "https://image.ibb.co/fpiaun/146.png", 1, 1, "Dica de CSS: Use :not para economizar tempo e linhas de código", "Larissa Mourullo", 1, "https://medium.com/devtranslate/dica-css-use-not-para-economizar-tempo-e-linhas-de-c%C3%B3digo-3cc16468d42f" },
                    { 147, "Christian Boxdörfer", "https://image.ibb.co/duXeLS/147.png", 1, 2, "FSearch", "-", 4, "https://hosted.weblate.org/engage/fsearch/?utm_source=widget" },
                    { 148, "Gabriel Weinberg", "https://image.ibb.co/gYWTEn/148.png", 1, 2, "DuckDuckGo", "-", 4, "https://duck.co/translate" },
                    { 141, "Max Ogden", "https://image.ibb.co/dNr5cR/141.png", 1, 1, "JavaScript para Gatos", "Carolina Pascale Campos", 1, "https://github.com/entrylvl/traducoes-de-artigos/blob/5eac7f0977fa3c669c521ae9a39f8e1faffb6627/javascript/javascript-para-gatos.md" },
                    { 149, "-", "https://image.ibb.co/iETx77/149.png", 1, 2, "Tutanota", "-", 4, "https://tutanota.com/blog/posts/tutanota-translation-project" },
                    { 151, "Elliot Dahl", "https://image.ibb.co/mpc777/151.png", 1, 1, "Querido Designer Jr.", "Pri Barella", 1, "https://code.likeagirl.io/querido-designer-jr-91e67c8950af" },
                    { 152, "XplentyBlog", "https://image.ibb.co/nMOrZn/152.png", 1, 1, "As diferenças entre SQL e NoSQL: MySQL x MongoDB", "Lauren Ferreira", 1, "https://medium.com/devtranslate/diferencas-entre-sql-e-nosql-51311f9069bd" },
                    { 153, "Marcus Gardiner", "https://image.ibb.co/fCvG0S/153.png", 1, 1, "Como se tornar um super ninja aprendiz de programação", "Vitor Martins", 1, "https://medium.com/devtranslate/como-se-tornar-um-super-ninja-aprendiz-de-programação-b51f2488f96c" },
                    { 154, "Vaidehi Joshi", "https://image.ibb.co/gii0un/154.png", 1, 1, "Grafos fantásticos e onde habitam: uma introdução à teoria dos grafos", "Lauren Ferreira", 1, "https://medium.com/devtranslate/grafos-fant%C3%A1sticos-e-onde-habitam-uma-introdu%C3%A7%C3%A3o-%C3%A0-teoria-dos-grafos-a7f9d737d5d2" },
                    { 155, "Electron", "https://impactotecno.files.wordpress.com/2018/02/electron1.jpg?w=640", 1, 2, "Documentação do Electron", "-", 3, "https://electronjs.org/docs?lang=pt-BR" },
                    { 156, "Vuex", "https://i.ibb.co/qYL9Wzr/156.png", 1, 1, "Documentação do Vuex", "-", 3, "https://vuex.vuejs.org/ptbr/" },
                    { 157, "Arianne Donoghue", "https://i.ibb.co/wrf0jBc/157.png", 1, 1, "O que você está esperando para falar em público?", "Lauren Ferreira ", 1, "https://medium.com/devtranslate/o-que-voc%C3%AA-t%C3%A1-esperando-para-falar-em-p%C3%BAblico-f75d12df1355" },
                    { 150, "Savoir-faire Linux Inc.", "https://image.ibb.co/iPPOEn/150.png", 1, 2, "Ring", "-", 4, "https://ring.cx/en/contribute/translate" },
                    { 120, "Ju Gonçalves", "https://image.ibb.co/kKHFjb/120.png", 1, 1, "Programação Funcional Deve Ser Sua Prioridade número #1 em 2015", "Eric Douglas e Diogo Beato", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/008-programacao-funcional-prioridade-2015.md" },
                    { 140, "Mariko Kosaka", "https://image.ibb.co/b1KfBm/140.png", 1, 1, "A promessa de uma festa do hambúrguer", "Caique Hitoshi Mitsuoka", 1, "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/promessa-festa-hamburguer/artigo.md" },
                    { 138, "Nicolas Gallagher", "https://image.ibb.co/fcFWHR/138.png", 1, 1, "CSS Idiomático", "Zeno Rocha", 3, "https://github.com/necolas/idiomatic-css/blob/master/translations/pt-BR/README.md" },
                    { 122, "Chris Sevilleja", "https://image.ibb.co/jSp6qG/122.png", 1, 1, "Uma introdução ao MongoDB", "Felipe Batista", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/MongoDB/001-uma-introduc%CC%A7a%CC%83o-ao-mongodb.md" },
                    { 123, "Brandon Satrom", "https://image.ibb.co/byLqHw/123.png", 1, 1, "Guia Para Absolutos Iniciantes em Node.js", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/nodejs/001-guia-para-iniciantes-absolutos-em-nodejs.md" },
                    { 124, "Christopher Buecheler", "https://image.ibb.co/k7wVHw/124.png", 1, 1, "Simples Guia Passo-a-Passo Para Desenvolvedores Front-End Iniciarem Com Node.js, Express, Jade e MongoDB", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/nodejs/002-simples-guia-nodejs-jade-express-mongodb.md" },
                    { 125, "Dave Ceddia", "https://image.ibb.co/mmNFjb/125.png", 1, 1, "Sua Linha do Tempo para Aprender React", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/react/01-sua-linha-do-tempo-para-aprender-react.md" },
                    { 126, "Robin Rendle", "https://image.ibb.co/k2c4cw/126.png", 1, 1, "Introdução ao React para pessoas que sabem apenas o suficiente de jQuery para sobreviver", "Eric Douglas", 1, "https://github.com/ericdouglas/traduz-ai/blob/master/react/02-introducao-ao-react-para-pessoas-que-sabem-apenas-jquery.md" },
                    { 127, "Naomi Ceder", "https://image.ibb.co/i7QCVG/127.png", 1, 1, "Por que VOCÊ deve escolher Python?", "Débora Azevedo", 1, "https://medium.com/nossa-coletividad/por-que-voc%C3%AA-deve-escolher-python-ad187b9783d0" },
                    { 128, "Aaron Kili", "https://image.ibb.co/n7OMPb/128.png", 1, 1, "Como instalar o pip para gerenciar pacotes do Python no GNU/Linux", "Allythy", 1, "https://allythy.github.io/Como-instalar-o-pip-para-gerenciar-pacotes-do-Python-no-GNU-Linux" },
                    { 139, "Mariko Kosaka", "https://image.ibb.co/c5VTWm/139.png", 1, 1, "Como ser* um compilador - Faça um compilador com JavaScript", "Caique Hitoshi Mitsuoka", 1, "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/como-ser-um-compilador--faca-um-compilador-com-javascript/artigo.md" },
                    { 129, "Python Software Foundation", "https://image.ibb.co/kTr84b/129.png", 1, 2, "Documentação do Python", "Comunidade Python", 3, "https://www.python.org/doc/" },
                    { 131, "Neal Brooks", "https://image.ibb.co/ncGQh6/131.png", 1, 1, "A comunidade global de PHP continua se intoxicando, e precisamos reverter isso antes que afete outros de nós", "William Oliveira", 1, "https://medium.com/devtranslate/a-comunidade-global-de-php-continua-se-intoxicando-e-precisamos-reverter-isso-antes-que-afete-da50ee793f8b" },
                    { 132, "Facebook", "https://image.ibb.co/bHm7P6/132.png", 1, 1, "Documentação do ReactJs", "Rafael Vianna e Gabriel Pireda", 3, "https://github.com/rafaelvianna/ReactJs-Docs-PT-BR" },
                    { 133, "Eric L. Barnes", "https://image.ibb.co/gfUrHR/133.png", 1, 1, "Laravel: Testando Parcialmente Respostas JSON", "Lucas Pires", 1, "https://medium.com/devtranslate/laravel-testando-parcialmente-respostas-json-320c6dc267d7" },
                    { 134, "ZingChart", "https://image.ibb.co/ntanrm/134.png", 1, 1, "Como Usar Variáveis CSS", "Larissa Mourullo", 1, "https://medium.com/devtranslate/como-usar-vari%C3%A1veis-css-29b5b980794c" },
                    { 135, "Alex Devero", "https://image.ibb.co/maw2rm/135.png", 1, 1, "CSS e 5 Erros Que Você Deve Evitar", "Larissa Mourullo", 1, "https://medium.com/devtranslate/css-e-5-erros-que-voc%C3%AA-deve-evitar-91b9872f63f4" },
                    { 136, "ngGirls", "https://image.ibb.co/jxW7P6/136.png", 1, 1, "Tutorial Angular para Iniciantes", "ngGirls", 4, "https://github.com/ng-girls/todo-list-tutorial-portuguese" },
                    { 137, "Mark Otto", "https://image.ibb.co/ku9K46/137.png", 1, 1, "Guia de Código do @mdo", "Diego Eis", 3, "http://diegoeis.github.io/code-guide/" },
                    { 130, "Brad Miller e David Ranum", "https://image.ibb.co/eZg84b/130.png", 1, 1, "Como Pensar Como um Cientista da Computação", "USP - Universidade de São Paulo", 1, "https://panda.ime.usp.br/pensepy/static/pensepy/index.html" },
                    { 158, "Tony You", "https://image.ibb.co/h9WOkG/29.png", 2, 1, "Programming Doesn’t Require Talent or Even Passion", "Modmaj", 1, "https://medium.com/@WordcorpGlobal/programming-doesnt-require-talent-or-even-passion-11422270e1e4" },
                    { 80, "Forbes Lindesay", "https://image.ibb.co/jyycxw/80.png", 1, 2, "PromiseJS", "Pedro Nauck, Eric Douglas, etc", 3, "https://github.com/pedronauck/promiseJS.br" },
                    { 78, "Hexo", "https://image.ibb.co/httzAG/78.png", 1, 2, "Documentação Hexo - Template Estático em Node.js", "Luciano Baraúna", 3, "https://github.com/lucianobarauna/dochexo" },
                    { 22, "Todd Motto", "https://image.ibb.co/jbASCw/22.png", 1, 1, "Por favor pare de se preocupar com o Angular 3", "Rodolfo Dias", 1, "https://medium.com/@r_mdias/por-favor-pare-de-se-preocupar-com-o-angular-3-c54e8e79f1fc#.i3ypcg3jb" },
                    { 23, "Sérgio Branco", "https://image.ibb.co/dxROkG/23.png", 1, 1, "Neutralidade da rede: você ama, mesmo não sabendo direito o que é", "Marianna Jardim", 1, "https://feed.itsrio.org/neutralidade-da-rede-você-ama-mesmo-não-sabendo-direito-o-que-é-5743f129563b#.b84or2sqt" },
                    { 24, "Sérgio Branco", "https://image.ibb.co/jkC7Cw/24.png", 1, 1, "Por que a Internet no Brasil é parcialmente livre?", "Beatriz Nunes", 1, "https://feed.itsrio.org/por-que-a-internet-no-brasil-é-parcialmente-livre-7b3832a657bd#.mue2uap9k" },
                    { 25, "Sérgio Branco", "https://image.ibb.co/kBr0Xw/25.png", 1, 1, "Os Futuros da Internet", "Beatriz Nunes", 1, "https://feed.itsrio.org/os-futuros-da-internet-8f629673efcd#.to0ilvw4t" },
                    { 26, "Nick Babich", "https://image.ibb.co/gTrOkG/26.png", 1, 1, "UX: Rolagem infinita vs. Paginação", "Renan C. Araujo", 1, "https://medium.com/ux-traduzido/ux-rolagem-infinita-vs-paginação-b7da06e72662#.o43hfullt" },
                    { 27, "Marshall Brain", "https://image.ibb.co/ntTQzb/27.png", 1, 1, "Como funcionam os servidores da Web", "Daniel Simão", 1, "https://medium.com/@simaodeveloper/como-funcionam-os-servidores-da-web-736542c386fa#.75jv8d7dc" },
                    { 28, "Testing Experience", "https://image.ibb.co/hsmZsw/28.png", 1, 1, "Metodologia Tradicional versus Ágil", "Wellington Marion", 1, "https://medium.com/@wellmarion/metodologia-tradicional-versus-ágil-e23bac9b12cb#.54cpdbvnq" },
                    { 21, "Tony C.", "https://image.ibb.co/fbCJKb/21.png", 1, 1, "Meu colega é um computador: Máquinas como força de trabalho", "Runrun.it", 1, "https://medium.com/liderar-e-dificil/meu-colega-%C3%A9-um-computador-m%C3%A1quinas-como-for%C3%A7a-de-trabalho-ca83e7f46e93" },
                    { 29, "Tony You", "https://image.ibb.co/h9WOkG/29.png", 1, 1, "Programming Doesn’t Require Talent or Even Passion", "Manuel Mendes", 1, "https://medium.com/@mdm.exe/programar-não-requer-talento-ou-paixão-36b0ae176782#.t24kokdrj" },
                    { 31, "Wes Bos", "https://image.ibb.co/cBrEcw/31.png", 1, 1, "Série ES6 by Wes Bos — Let vs const", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/série-es6-by-wes-bos-let-vs-const-f521beef074a#.kcmvimmze" },
                    { 32, "Wes Bos", "https://image.ibb.co/fjPBPb/32.png", 1, 1, "Série ES6 by Wes Bos — Use let com for loops em JavaScript", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/série-es6-by-wes-bos-use-let-com-for-loops-em-javascript-891922dcea49#.dv05gwm0f" },
                    { 33, "Manuel Matuzovic", "https://image.ibb.co/e0e0Hw/33.png", 1, 1, "Escrevendo JavaScript com acessibilidade em mente", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/escrevendo-javascript-com-acessibilidade-em-mente-3720e9779969#.mmux2td5q" },
                    { 34, "Kalin Chernev", "https://image.ibb.co/nbf7xw/34.png", 1, 1, "Reflexão em padrões de projeto para Node.js", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/reflex%C3%A3o-em-padr%C3%B5es-de-projeto-para-node-js-b7344f2529c7#.gy5lnmau4" },
                    { 35, "Wes Bos", "https://image.ibb.co/fnUNVG/35.png", 1, 1, "4 novos métodos de string em ES6 que você deveria conhecer", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/4-novos-m%C3%A9todos-de-string-em-es6-que-voc%C3%AA-deveria-conhecer-e85c7262123c#.o8tvbjyke" },
                    { 36, "Kamran Ahmed", "https://image.ibb.co/dXsLHw/36.png", 1, 1, "Design Patterns para Humanos", "Lucas Santos", 2, "https://github.com/khaosdoctor/design-patterns-for-humans/tree/translation" },
                    { 37, "Scott Domes", "https://image.ibb.co/jp07xw/37.png", 1, 1, "Como o Flexbox funciona— explicado com gifs grandes e coloridos", "Lucas Silva", 1, "https://medium.com/@lucasjs/como-o-flexbox-funciona-explicado-com-gifs-grandes-e-coloridos-26c42a0bcdc" },
                    { 30, "Wes Bos", "https://image.ibb.co/nepnCw/30.png", 1, 1, "Série ES6 by Wes Bos — Como let e const são ‘escopados’ em JavaScript parte 1", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/como-let-const-sao-escopados-f190b632879b#.s1p2hbnp1" },
                    { 38, "DWYL", "https://image.ibb.co/dJz0Hw/38.png", 1, 1, "Aprenda Istanbul", "Lucas Santos", 1, "https://github.com/khaosdoctor/learn-istanbul" },
                    { 20, "JetBrains", "https://image.ibb.co/ctK9QG/20.png", 1, 1, "Kotlin 1.1 - Suporte a Javascript, Coroutines e mais", "Walmyr Carvalho", 1, "https://medium.com/@walmyrcarvalho/kotlin-1-1-suporte-a-javascript-co-rotinas-e-mais-d84b65ac2f92#.9usvgmws0" },
                    { 18, "Štefan Maric", "https://image.ibb.co/gbKnCw/18.png", 1, 1, "Aventuras funcionais ocasionais em JavaScript", "Jean Carlo Nascimento", 1, "https://medium.com/@osuissa/aventuras-funcionais-ocasionais-em-javascript-54d3e168c4da" },
                    { 2, "Manuel Matuzovic", "https://image.ibb.co/exTEsw/2.png", 1, 1, "Escrevendo HTML com acessibilidade em mente", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/escrevendo-html-com-acessibilidade-em-mente-4af1b8599246" },
                    { 3, "Steven Bradley", "https://image.ibb.co/cn49QG/3.png", 1, 1, "Entendendo a precedência de estilo em CSS: Especificidade, Herança e Efeito Cascata", "Emanuel G de Souza", 1, "https://medium.com/emanuelg-blog/entendendo-a-preced%C3%AAncia-de-estilo-em-css-especificidade-heran%C3%A7a-e-efeito-cascata-a437c4929173" },
                    { 4, "Ignacio Piantanida", "https://image.ibb.co/jWZXeb/4.png", 1, 1, "CSS: do ‘Odeio essa m**’ a ‘pode deixar comigo!’", "Leandro Cavalcante", 1, "https://medium.com/@leandrw/css-do-odeio-essa-m-a-pode-deixar-comigo-f4203edfaec5" },
                    { 5, "Perez Priego", "https://image.ibb.co/kKeb5G/5.png", 1, 1, "A evolução do CSS: De arquivos CSS, SASS, BEM para CSS Modules até Styled Components", "Eduardo Rabelo", 1, "https://medium.com/tableless/a-evolu%C3%A7%C3%A3o-do-css-de-arquivos-css-sass-bem-para-css-modules-at%C3%A9-styled-components-b7ad4d16ffc2" },
                    { 6, "Marcelo Somers", "https://image.ibb.co/i0WZsw/6_OK.png", 1, 1, "A ascensão do Functional CSS", "Eduardo Rabelo", 1, "https://medium.com/tableless/a-ascens%C3%A3o-do-functional-css-8ae81ac2aa9c" },
                    { 7, "Krasimir Tsonev", "https://image.ibb.co/mECw5G/7.png", 1, 1, "Construindo uma aplicação sem CSS — Os altos e baixos sobre isso", "Eduardo Rabelo", 1, "https://medium.com/@oieduardorabelo/construindo-uma-aplica%C3%A7%C3%A3o-sem-css-os-altos-e-baixos-sobre-isso-33d8a218c72f" },
                    { 8, "Adam Morse", "https://image.ibb.co/dmifXw/8_OK.png", 1, 1, "CSS e Escalabilidade — Nós deveríamos escrever menos CSS", "Eduardo Rabelo", 1, "https://medium.com/tableless/css-e-escalabilidade-n%C3%B3s-dever%C3%ADamos-escrever-menos-css-7bf9d4749519" },
                    { 19, "James Kyle", "https://image.ibb.co/jKJQzb/19_OK.png", 1, 1, "Novos campos de classe #private no JavaScript", "Danilo Vaz", 1, "https://medium.com/trainingcenter/novos-campos-de-classe-private-no-javascript-2622d5faa65e" },
                    { 9, "Mark Dalgleish", "https://image.ibb.co/ctEXeb/9.png", 1, 1, "O fim do CSS global", "Eduardo Rabelo", 1, "https://medium.com/tableless/o-fim-do-css-global-ddcd80bd6334" },
                    { 11, "Ire Aderinokun", "https://image.ibb.co/bWwZsw/11.png", 1, 1, "3 novidades do CSS para aprender em 2017", "Eduardo Rabelo", 1, "https://medium.com/tableless/3-novidades-do-css-para-aprender-em-2017-15b65acb85d8" },
                    { 12, "Jonathan Snook", "https://image.ibb.co/hSe9QG/12.png", 1, 1, "Qual mudança que Web Components causa na arquitetura CSS?", "Eduardo Rabelo", 1, "https://medium.com/@oieduardorabelo/qual-mudan%C3%A7a-que-web-components-causa-na-arquitetura-css-5a4b6fdb6a98" },
                    { 13, "Jose Aguinaga", "https://image.ibb.co/nDv5zb/13_OK.png", 1, 1, "Como é programar em JavaScript em 2016", "Joselito Júnior (PT-BR)", 1, "https://codetalks.net/como-%C3%A9-programar-em-javascript-em-2016-9c9b3c12cea8" },
                    { 14, "Ryan McDermott", "https://image.ibb.co/iz4b5G/14_OK.png", 1, 1, "Código Limpo em Javascript", "Felipe Augusto", 2, "https://github.com/felipe-augusto/clean-code-javascript/blob/master/README.md" },
                    { 15, "Lucas Fernandes da Costa", "https://image.ibb.co/hr9Xeb/15.png", 1, 1, "Tudo sobre Recursão, PTC, TCO e STC em JavaScript", "Jean Carlo Nascimento", 1, "https://medium.com/@osuissa/tudo-sobre-recurs%C3%A3o-ptc-tco-e-stc-em-javascript-58953a5a846a" },
                    { 16, "Forbes Lindesay", "https://image.ibb.co/korOkG/16_OK.png", 1, 1, "JavaScript - Promises", "Jean Carlo Nascimento", 3, "https://medium.com/@osuissa/javascript-promises-671934f08bdf" },
                    { 17, "A. Sharif", "https://image.ibb.co/fwBOkG/17.png", 1, 1, "Flow: Fundamentos para Desenvolvedores JavaScript", "Eduardo Rabelo", 4, "https://medium.com/trainingcenter/flow-fundamentos-para-desenvolvedores-javascript-9f0a1da74c4e" },
                    { 10, "Jarno Rantanen", "https://image.ibb.co/krsw5G/10_OK.png", 1, 1, "8 regras simples para uma arquitetura CSS robusta e escalável", "Eduardo Rabelo", 1, "https://medium.com/tableless/8-regras-simples-para-uma-arquitetura-css-robusta-e-escal%C3%A1vel-545c6dade170" },
                    { 79, "Simon Cozens", "https://image.ibb.co/eCc4cw/79.png", 1, 2, "Beginning Perl", "Blabos de Blebe, Solli Moreira, etc", 2, "https://github.com/shonorio/beginning-perl" },
                    { 39, "Jacopo Daeli", "https://image.ibb.co/e58hVG/39.png", 1, 1, "O que significa const no ES6?", "Jean Carlo Nascimento", 1, "https://github.com/suissa/blog/tree/master/traducoes/What%20does%20const%20stand%20for%20in%20ES6%3F" },
                    { 41, "Lukas Zkups", "https://image.ibb.co/eboSxw/41.png", 1, 1, "Vue.js vale a tentativa?", "Walter Gandarella", 1, "https://blog.wgbn.com.br/vue-js-vale-a-tentativa-6e63b6e74a3b" },
                    { 62, "Addy Osmani", "https://image.ibb.co/jMs9AG/62_OK.png", 1, 1, "Learning JavaScript Design Patterns", "Eliel das Virgens Santos", 2, "https://github.com/hc3/essencial-js-padroes-de-projeto" },
                    { 63, "Chris Schneider", "https://image.ibb.co/dfU0Hw/63.png", 1, 1, "Sinatra Book", "Tailor Fontela e Giovani Generali", 2, "https://github.com/taylorrf/sinatra-book-pt-br" },
                    { 64, "John Papa", "https://image.ibb.co/fc0kjb/64.png", 1, 1, "Guia de Estilo AngularJS", "Lennon Jesus, Lucas Moreira e Bruno Wego", 2, "https://github.com/gilsondev/angular-styleguide-pt-br/blob/master/SUMMARY.md" },
                    { 65, "Code School", "https://image.ibb.co/jtA7xw/65.png", 1, 1, "Experimente Git", "Gustavo Franco", 2, "https://github.com/mandado/Experimente-Git" },
                    { 66, "Adam Silver", "https://image.ibb.co/eNL7xw/66.png", 1, 1, "CSS Sustentável", "Ayrton Fidélis, Gabriel Bastos e Talita Pagani", 2, "http://csssustentavel.com.br/" },
                    { 67, "Noam Elfanbaum e Udi Oron", "https://image.ibb.co/mxPpAG/67.png", 1, 1, "Pycubator", "Gilson Filho, Noam Elfanbaum, James Peres, etc", 2, "http://df.python.org.br/pycubator/" },
                    { 68, "Al Sweigart", "https://image.ibb.co/gDfUAG/68_OK.png", 1, 2, "Making Games With Python & Pygame", "Iury Alves e Eduardo Saito", 2, "https://github.com/IuryAlves/pygame-book-translation" },
                    { 61, "Node School", "https://image.ibb.co/dAjd4b/61_OK.png", 1, 1, "Learn You Node", "Lucas Fernandes da Costa, Eric Douglas, Lucas Vieira, etc", 2, "https://github.com/lucasfcosta/learnyounode-pt-br" },
                    { 69, "Miran Lipovaca", "https://image.ibb.co/iY6Qjb/69_OK.png", 1, 2, "Aprender Haskell Será um Grande Bem Para Você", "Tailor Fontela, Bruno Soares da Silva, etc", 2, "https://github.com/taylorrf/learnhaskell" },
                    { 71, "Chris Daley", "https://image.ibb.co/j6NFjb/71_OK.png", 1, 2, "The Vala Tutorial", "Fernando da Silva Sousa, Leonardo Lemos, etc", 2, "https://github.com/elementary-br/the-vala-tutorial" },
                    { 72, "Nigel George", "https://image.ibb.co/exsLHw/72_OK.png", 1, 2, "The Django Book", "Douglas Miranda, Marcelo J. Both, Londerson, etc", 2, "https://github.com/erichideki/djangobook" },
                    { 73, "Matthew Weier O'Phinney", "https://image.ibb.co/jytzAG/73_OK.png", 1, 2, "PHP Standards Recommendations", "Enrico Pereira", 3, "https://github.com/aaoliveira/PSR_PT-BR" },
                    { 74, "Jekyll", "https://image.ibb.co/jzRajb/74.png", 1, 2, "Documentação do Jekyll", "Fernando Moreira, Raphael Barreto, etc", 3, "https://github.com/jekyll-brasil/jekyll-brasil.github.io" },
                    { 75, "Facebook", "https://image.ibb.co/gnJo4b/75.png", 1, 2, "Documentação do React", "Willian Mano e Fabio Soares", 3, "https://github.com/willianmano/reactdocs-pt_br" },
                    { 76, "Composer", "https://image.ibb.co/ju1VHw/76.png", 1, 2, "Documentação do Composer", "Nando Kstro, Alfredo Braga e Gustavo Pereira", 3, "https://github.com/NandoKstroNet/docs-composer-pt-br" },
                    { 77, "Prism", "https://image.ibb.co/hs7gPb/77.png", 1, 2, "Prism for Xamarin Forms", "Angelo Luis, Ronildo N. Souza e Jonathan Braga", 3, "https://github.com/angelobelchior/prism-xamarin-forms" },
                    { 70, "Harry Roberts", "https://image.ibb.co/dQEBPb/70.png", 1, 2, "CSS Guideline", "Jhon Donavan, Lucas da Silva Trindade, Larissa Mourullo, etc", 3, "https://github.com/GDGDuqueDeCaxias/cssguideline-translate-ptbr" },
                    { 40, "William Oliveira", "https://image.ibb.co/jjgfHw/40.png", 1, 1, "Carreira Front-End", "William Oliveira, Bruno Silva, Ricardo Shiota Yasuda, Gabriel Brito e Danilo Vaz", 4, "https://github.com/woliveiras/front-end-career/blob/master/translations/pt-br/README.md" },
                    { 60, "Allen B. Downey", "https://image.ibb.co/iY2nxw/60_OK.png", 1, 1, "Pense em Python", "Diego Rocha, Luciano Ramalho e Wellington Moraes", 2, "https://github.com/PenseAllen/PensePython2e" },
                    { 58, "Addy Osmani", "https://image.ibb.co/jeC9AG/58.png", 1, 1, "Padrões de Projeto JavaScript", "Eric Oliveira", 2, "https://github.com/fhferreira/aprendendo-padroes-de-projeto-javascript" },
                    { 42, "Chris Esplin", "https://image.ibb.co/naySxw/42.png", 1, 1, "FIRE Stack, uma nova arquitetura", "Walter Gandarella", 1, "https://blog.wgbn.com.br/fire-stack-uma-nova-arquitetura-11f33b4fb3f" },
                    { 43, "Dima Kovalenko", "https://image.ibb.co/g4xLHw/43.png", 1, 1, "Como Kotlin se tornou a nossa linguagem principal para Android", "Wellington Mitrut", 1, "https://medium.com/blog-do-mitrut/como-kotlin-se-tornou-a-nossa-linguagem-principal-para-android-24c9492fa273" },
                    { 44, "Colby Williams", "https://image.ibb.co/ed7LHw/44.png", 1, 1, "Xamarin vs. Nativo", "Wellington Mitrut", 1, "https://medium.com/blog-do-mitrut/xamarin-vs-nativo-36e46ec2c566" },
                    { 45, "Colby Williams", "https://image.ibb.co/hFxbqG/45.png", 1, 1, "Então Você Quer Ser um Programador Funcional (Parte 1)", "Charles Scalfani", 1, "https://medium.com/@mapaiva/ent%C3%A3o-voc%C3%AA-quer-ser-um-programador-funcional-parte-1-f3bdb7baeedb" },
                    { 46, "Donald Stuff", "https://image.ibb.co/kabEcw/46.png", 1, 1, "PyPi — Quem mantém e como", "Cadu Leite", 1, "https://medium.com/@cadu_leite/mantendo-o-%C3%ADndice-de-pacotes-python-pypi-deb403b0d984" },
                    { 47, "Golang", "https://image.ibb.co/dAMfHw/47.png", 1, 1, "Como escrever código Go", "Viliam", 3, "https://medium.com/@viliamjr/como-escrever-codigo-go-95381b84ba82" },
                    { 48, "Rob Pike", "https://image.ibb.co/jMZpAG/48.png", 1, 1, "As 5 Regras da Programação - Segundo Rob Pike", "Viliam", 1, "https://medium.com/@viliamjr/as-5-regras-da-programacao-segundo-rob-pike-ae3c8b599f50" },
                    { 59, "Mislav Marohnić", "https://image.ibb.co/n1aUAG/59_OK.png", 1, 1, "Why's (Poignant) Guide to Ruby", "Carlos Brando, Hugo Borges, Marcos Piccinini, etc", 2, "https://github.com/carlosbrando/poignant-br" },
                    { 49, "Rachel Weidinger, Cooper Quintin, Martin Shelton e Matt Mitchell", "https://image.ibb.co/e94pAG/49.png", 1, 1, "Como dar um treinamento de segurança digital", "Narrira Lemos", 1, "https://medium.com/@narriral/como-dar-um-treinamento-de-seguran%C3%A7a-digital-48c1df2f0b35" },
                    { 51, "Daniel Gallegos", "https://image.ibb.co/d86Qjb/51.png", 1, 1, "Como usar o GitHub como um ser humano adequado", "Juliano Padilha", 1, "https://medium.com/@julianopadilha/como-usar-o-github-como-um-ser-humano-adequado-5a0a2e1afd18" },
                    { 52, "PHP-Fig", "https://image.ibb.co/iv9d4b/52.png", 1, 1, "PSR-2 pt-BR Classes", "Artur Afonso", 3, "https://blog.arturafonso.com.br/psr-2-pt-br-classes-fe332b6421fd" },
                    { 53, "Todd Motto", "https://image.ibb.co/mtO5jb/53.png", 1, 1, "Substituindo instruções de switch por objetos literais", "Jean Carlo Nascimento", 1, "https://medium.com/@osuissa/substituindo-instru%C3%A7%C3%B5es-de-switch-por-objetos-literais-93a3a78463a1" },
                    { 54, "Dinah Davis", "https://image.ibb.co/meo5jb/54.png", 1, 1, "Garotas precisam de bons exemplos", "Andressa Chiara", 1, "https://code.likeagirl.io/garotas-precisam-de-bons-exemplos-5c4ba026bacf" },
                    { 55, "Jonathan Howard", "https://image.ibb.co/hSfJ4b/55.png", 1, 1, "Como os homens podem ajudar as mulheres em TI?", "Marco Dubovski", 1, "https://code.likeagirl.io/como-os-homens-podem-ajudar-as-mulheres-em-ti-ec6f75cacdf8" },
                    { 56, "Marijn Haverbeke", "https://image.ibb.co/gYRrPb/56.png", 1, 1, "Eloquente JavaScript", "Eric Douglas, Saulo Santiago, Joao Stein, etc", 2, "https://github.com/braziljs/eloquente-javascript" },
                    { 57, "Apple", "https://image.ibb.co/kn6Ecw/57.png", 1, 2, "The Swift Programming Language", "CocoaHeadsBrasil", 2, "https://github.com/CocoaHeadsBrasil/the-swift-programming-language-in-portuguese-br" },
                    { 50, "Corona Labs", "https://image.ibb.co/cx79AG/50.png", 1, 1, "Aprenda lua em 15 minutos", "Júnior Pires", 1, "https://medium.com/@junior_pires/saaripar-valida%C3%A7%C3%A3o-de-campos-no-android-9d35821a493d" },
                    { 159, "William Oliveira", "https://image.ibb.co/jjgfHw/40.png", 2, 1, "Front End Career", "William Oliveira, Bruno Silva, Ricardo Shiota Yasuda, Gabriel Brito, Danilo Vaz", 4, "https://github.com/woliveiras/front-end-career/tree/master/translations/en" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "translations",
                keyColumn: "id",
                keyValue: 159);
        }
    }
}
