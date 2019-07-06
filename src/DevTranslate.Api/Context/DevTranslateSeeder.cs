using DevTranslate.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevTranslate.Api.Context
{
    public static class DevTranslateSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Translation>().HasData(
                new
                {
                    Id = 1,
                    Title = "Pare de usar CSS no JavaScript para desenvolvimento web",
                    Author = "Gajus Kuizinas",
                    Translator = "Carlos Eduardo Olivieri",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@cadutech/pare-de-usar-css-no-javascript-para-desenvolvimento-web-b4a2e8fbb85e",
                    ImageUrl = "https://image.ibb.co/b9GdKb/1.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 2,
                    Title = "Escrevendo HTML com acessibilidade em mente",
                    Author = "Manuel Matuzovic",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/escrevendo-html-com-acessibilidade-em-mente-4af1b8599246",
                    ImageUrl = "https://image.ibb.co/exTEsw/2.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 3,
                    Title = "Entendendo a precedência de estilo em CSS: Especificidade, Herança e Efeito Cascata",
                    Author = "Steven Bradley",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/entendendo-a-preced%C3%AAncia-de-estilo-em-css-especificidade-heran%C3%A7a-e-efeito-cascata-a437c4929173",
                    ImageUrl = "https://image.ibb.co/cn49QG/3.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 4,
                    Title = "CSS: do ‘Odeio essa m**’ a ‘pode deixar comigo!’",
                    Author = "Ignacio Piantanida",
                    Translator = "Leandro Cavalcante",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@leandrw/css-do-odeio-essa-m-a-pode-deixar-comigo-f4203edfaec5",
                    ImageUrl = "https://image.ibb.co/jWZXeb/4.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 5,
                    Title = "A evolução do CSS: De arquivos CSS, SASS, BEM para CSS Modules até Styled Components",
                    Author = "Perez Priego",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/tableless/a-evolu%C3%A7%C3%A3o-do-css-de-arquivos-css-sass-bem-para-css-modules-at%C3%A9-styled-components-b7ad4d16ffc2",
                    ImageUrl = "https://image.ibb.co/kKeb5G/5.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 6,
                    Title = "A ascensão do Functional CSS",
                    Author = "Marcelo Somers",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/tableless/a-ascens%C3%A3o-do-functional-css-8ae81ac2aa9c",
                    ImageUrl = "https://image.ibb.co/i0WZsw/6_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 7,
                    Title = "Construindo uma aplicação sem CSS — Os altos e baixos sobre isso",
                    Author = "Krasimir Tsonev",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@oieduardorabelo/construindo-uma-aplica%C3%A7%C3%A3o-sem-css-os-altos-e-baixos-sobre-isso-33d8a218c72f",
                    ImageUrl = "https://image.ibb.co/mECw5G/7.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 8,
                    Title = "CSS e Escalabilidade — Nós deveríamos escrever menos CSS",
                    Author = "Adam Morse",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/tableless/css-e-escalabilidade-n%C3%B3s-dever%C3%ADamos-escrever-menos-css-7bf9d4749519",
                    ImageUrl = "https://image.ibb.co/dmifXw/8_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 9,
                    Title = "O fim do CSS global",
                    Author = "Mark Dalgleish",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/tableless/o-fim-do-css-global-ddcd80bd6334",
                    ImageUrl = "https://image.ibb.co/ctEXeb/9.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 10,
                    Title = "8 regras simples para uma arquitetura CSS robusta e escalável",
                    Author = "Jarno Rantanen",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/tableless/8-regras-simples-para-uma-arquitetura-css-robusta-e-escal%C3%A1vel-545c6dade170",
                    ImageUrl = "https://image.ibb.co/krsw5G/10_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 11,
                    Title = "3 novidades do CSS para aprender em 2017",
                    Author = "Ire Aderinokun",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/tableless/3-novidades-do-css-para-aprender-em-2017-15b65acb85d8",
                    ImageUrl = "https://image.ibb.co/bWwZsw/11.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 12,
                    Title = "Qual mudança que Web Components causa na arquitetura CSS?",
                    Author = "Jonathan Snook",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@oieduardorabelo/qual-mudan%C3%A7a-que-web-components-causa-na-arquitetura-css-5a4b6fdb6a98",
                    ImageUrl = "https://image.ibb.co/hSe9QG/12.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 13,
                    Title = "Como é programar em JavaScript em 2016",
                    Author = "Jose Aguinaga",
                    Translator = "Joselito Júnior (PT-BR)",
                    Language = Language.Portuguese,
                    Url = "https://codetalks.net/como-%C3%A9-programar-em-javascript-em-2016-9c9b3c12cea8",
                    ImageUrl = "https://image.ibb.co/nDv5zb/13_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 14,
                    Title = "Código Limpo em Javascript",
                    Author = "Ryan McDermott",
                    Translator = "Felipe Augusto",
                    Language = Language.Portuguese,
                    Url = "https://github.com/felipe-augusto/clean-code-javascript/blob/master/README.md",
                    ImageUrl = "https://image.ibb.co/iz4b5G/14_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 15,
                    Title = "Tudo sobre Recursão, PTC, TCO e STC em JavaScript",
                    Author = "Lucas Fernandes da Costa",
                    Translator = "Jean Carlo Nascimento",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@osuissa/tudo-sobre-recurs%C3%A3o-ptc-tco-e-stc-em-javascript-58953a5a846a",
                    ImageUrl = "https://image.ibb.co/hr9Xeb/15.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 16,
                    Title = "JavaScript - Promises",
                    Author = "Forbes Lindesay",
                    Translator = "Jean Carlo Nascimento",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@osuissa/javascript-promises-671934f08bdf",
                    ImageUrl = "https://image.ibb.co/korOkG/16_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 17,
                    Title = "Flow: Fundamentos para Desenvolvedores JavaScript",
                    Author = "A. Sharif",
                    Translator = "Eduardo Rabelo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/trainingcenter/flow-fundamentos-para-desenvolvedores-javascript-9f0a1da74c4e",
                    ImageUrl = "https://image.ibb.co/fwBOkG/17.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 18,
                    Title = "Aventuras funcionais ocasionais em JavaScript",
                    Author = "Štefan Maric",
                    Translator = "Jean Carlo Nascimento",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@osuissa/aventuras-funcionais-ocasionais-em-javascript-54d3e168c4da",
                    ImageUrl = "https://image.ibb.co/gbKnCw/18.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 19,
                    Title = "Novos campos de classe #private no JavaScript",
                    Author = "James Kyle",
                    Translator = "Danilo Vaz",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/trainingcenter/novos-campos-de-classe-private-no-javascript-2622d5faa65e",
                    ImageUrl = "https://image.ibb.co/jKJQzb/19_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 20,
                    Title = "Kotlin 1.1 - Suporte a Javascript, Coroutines e mais",
                    Author = "JetBrains",
                    Translator = "Walmyr Carvalho",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@walmyrcarvalho/kotlin-1-1-suporte-a-javascript-co-rotinas-e-mais-d84b65ac2f92#.9usvgmws0",
                    ImageUrl = "https://image.ibb.co/ctK9QG/20.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 21,
                    Title = "Meu colega é um computador: Máquinas como força de trabalho",
                    Author = "Tony C.",
                    Translator = "Runrun.it",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/liderar-e-dificil/meu-colega-%C3%A9-um-computador-m%C3%A1quinas-como-for%C3%A7a-de-trabalho-ca83e7f46e93",
                    ImageUrl = "https://image.ibb.co/fbCJKb/21.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 22,
                    Title = "Por favor pare de se preocupar com o Angular 3",
                    Author = "Todd Motto",
                    Translator = "Rodolfo Dias",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@r_mdias/por-favor-pare-de-se-preocupar-com-o-angular-3-c54e8e79f1fc#.i3ypcg3jb",
                    ImageUrl = "https://image.ibb.co/jbASCw/22.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 23,
                    Title = "Neutralidade da rede: você ama, mesmo não sabendo direito o que é",
                    Author = "Sérgio Branco",
                    Translator = "Marianna Jardim",
                    Language = Language.Portuguese,
                    Url = "https://feed.itsrio.org/neutralidade-da-rede-você-ama-mesmo-não-sabendo-direito-o-que-é-5743f129563b#.b84or2sqt",
                    ImageUrl = "https://image.ibb.co/dxROkG/23.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 24,
                    Title = "Por que a Internet no Brasil é parcialmente livre?",
                    Author = "Sérgio Branco",
                    Translator = "Beatriz Nunes",
                    Language = Language.Portuguese,
                    Url = "https://feed.itsrio.org/por-que-a-internet-no-brasil-é-parcialmente-livre-7b3832a657bd#.mue2uap9k",
                    ImageUrl = "https://image.ibb.co/jkC7Cw/24.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 25,
                    Title = "Os Futuros da Internet",
                    Author = "Sérgio Branco",
                    Translator = "Beatriz Nunes",
                    Language = Language.Portuguese,
                    Url = "https://feed.itsrio.org/os-futuros-da-internet-8f629673efcd#.to0ilvw4t",
                    ImageUrl = "https://image.ibb.co/kBr0Xw/25.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 26,
                    Title = "UX: Rolagem infinita vs. Paginação",
                    Author = "Nick Babich",
                    Translator = "Renan C. Araujo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/ux-traduzido/ux-rolagem-infinita-vs-paginação-b7da06e72662#.o43hfullt",
                    ImageUrl = "https://image.ibb.co/gTrOkG/26.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 27,
                    Title = "Como funcionam os servidores da Web",
                    Author = "Marshall Brain",
                    Translator = "Daniel Simão",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@simaodeveloper/como-funcionam-os-servidores-da-web-736542c386fa#.75jv8d7dc",
                    ImageUrl = "https://image.ibb.co/ntTQzb/27.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 28,
                    Title = "Metodologia Tradicional versus Ágil",
                    Author = "Testing Experience",
                    Translator = "Wellington Marion",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@wellmarion/metodologia-tradicional-versus-ágil-e23bac9b12cb#.54cpdbvnq",
                    ImageUrl = "https://image.ibb.co/hsmZsw/28.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 29,
                    Title = "Programming Doesn’t Require Talent or Even Passion",
                    Author = "Tony You",
                    Translator = "Manuel Mendes",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@mdm.exe/programar-não-requer-talento-ou-paixão-36b0ae176782#.t24kokdrj",
                    ImageUrl = "https://image.ibb.co/h9WOkG/29.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 30,
                    Title = "Série ES6 by Wes Bos — Como let e const são ‘escopados’ em JavaScript parte 1",
                    Author = "Wes Bos",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/como-let-const-sao-escopados-f190b632879b#.s1p2hbnp1",
                    ImageUrl = "https://image.ibb.co/nepnCw/30.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 31,
                    Title = "Série ES6 by Wes Bos — Let vs const",
                    Author = "Wes Bos",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/série-es6-by-wes-bos-let-vs-const-f521beef074a#.kcmvimmze",
                    ImageUrl = "https://image.ibb.co/cBrEcw/31.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 32,
                    Title = "Série ES6 by Wes Bos — Use let com for loops em JavaScript",
                    Author = "Wes Bos",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/série-es6-by-wes-bos-use-let-com-for-loops-em-javascript-891922dcea49#.dv05gwm0f",
                    ImageUrl = "https://image.ibb.co/fjPBPb/32.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 33,
                    Title = "Escrevendo JavaScript com acessibilidade em mente",
                    Author = "Manuel Matuzovic",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/escrevendo-javascript-com-acessibilidade-em-mente-3720e9779969#.mmux2td5q",
                    ImageUrl = "https://image.ibb.co/e0e0Hw/33.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 34,
                    Title = "Reflexão em padrões de projeto para Node.js",
                    Author = "Kalin Chernev",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/reflex%C3%A3o-em-padr%C3%B5es-de-projeto-para-node-js-b7344f2529c7#.gy5lnmau4",
                    ImageUrl = "https://image.ibb.co/nbf7xw/34.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 35,
                    Title = "4 novos métodos de string em ES6 que você deveria conhecer",
                    Author = "Wes Bos",
                    Translator = "Emanuel G de Souza",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/emanuelg-blog/4-novos-m%C3%A9todos-de-string-em-es6-que-voc%C3%AA-deveria-conhecer-e85c7262123c#.o8tvbjyke",
                    ImageUrl = "https://image.ibb.co/fnUNVG/35.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 36,
                    Title = "Design Patterns para Humanos",
                    Author = "Kamran Ahmed",
                    Translator = "Lucas Santos",
                    Language = Language.Portuguese,
                    Url = "https://github.com/khaosdoctor/design-patterns-for-humans/tree/translation",
                    ImageUrl = "https://image.ibb.co/dXsLHw/36.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 37,
                    Title = "Como o Flexbox funciona— explicado com gifs grandes e coloridos",
                    Author = "Scott Domes",
                    Translator = "Lucas Silva",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@lucasjs/como-o-flexbox-funciona-explicado-com-gifs-grandes-e-coloridos-26c42a0bcdc",
                    ImageUrl = "https://image.ibb.co/jp07xw/37.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 38,
                    Title = "Aprenda Istanbul",
                    Author = "DWYL",
                    Translator = "Lucas Santos",
                    Language = Language.Portuguese,
                    Url = "https://github.com/khaosdoctor/learn-istanbul",
                    ImageUrl = "https://image.ibb.co/dJz0Hw/38.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 39,
                    Title = "O que significa const no ES6?",
                    Author = "Jacopo Daeli",
                    Translator = "Jean Carlo Nascimento",
                    Language = Language.Portuguese,
                    Url = "https://github.com/suissa/blog/tree/master/traducoes/What%20does%20const%20stand%20for%20in%20ES6%3F",
                    ImageUrl = "https://image.ibb.co/e58hVG/39.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 40,
                    Title = "Carreira Front-End",
                    Author = "William Oliveira",
                    Translator = "William Oliveira, Bruno Silva, Ricardo Shiota Yasuda, Gabriel Brito e Danilo Vaz",
                    Language = Language.Portuguese,
                    Url = "https://github.com/woliveiras/front-end-career/blob/master/translations/pt-br/README.md",
                    ImageUrl = "https://image.ibb.co/jjgfHw/40.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 41,
                    Title = "Vue.js vale a tentativa?",
                    Author = "Lukas Zkups",
                    Translator = "Walter Gandarella",
                    Language = Language.Portuguese,
                    Url = "https://blog.wgbn.com.br/vue-js-vale-a-tentativa-6e63b6e74a3b",
                    ImageUrl = "https://image.ibb.co/eboSxw/41.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 42,
                    Title = "FIRE Stack, uma nova arquitetura",
                    Author = "Chris Esplin",
                    Translator = "Walter Gandarella",
                    Language = Language.Portuguese,
                    Url = "https://blog.wgbn.com.br/fire-stack-uma-nova-arquitetura-11f33b4fb3f",
                    ImageUrl = "https://image.ibb.co/naySxw/42.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 43,
                    Title = "Como Kotlin se tornou a nossa linguagem principal para Android",
                    Author = "Dima Kovalenko",
                    Translator = "Wellington Mitrut",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/blog-do-mitrut/como-kotlin-se-tornou-a-nossa-linguagem-principal-para-android-24c9492fa273",
                    ImageUrl = "https://image.ibb.co/g4xLHw/43.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 44,
                    Title = "Xamarin vs. Nativo",
                    Author = "Colby Williams",
                    Translator = "Wellington Mitrut",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/blog-do-mitrut/xamarin-vs-nativo-36e46ec2c566",
                    ImageUrl = "https://image.ibb.co/ed7LHw/44.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 45,
                    Title = "Então Você Quer Ser um Programador Funcional (Parte 1)",
                    Author = "Colby Williams",
                    Translator = "Charles Scalfani",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@mapaiva/ent%C3%A3o-voc%C3%AA-quer-ser-um-programador-funcional-parte-1-f3bdb7baeedb",
                    ImageUrl = "https://image.ibb.co/hFxbqG/45.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 46,
                    Title = "PyPi — Quem mantém e como",
                    Author = "Donald Stuff",
                    Translator = "Cadu Leite",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@cadu_leite/mantendo-o-%C3%ADndice-de-pacotes-python-pypi-deb403b0d984",
                    ImageUrl = "https://image.ibb.co/kabEcw/46.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 47,
                    Title = "Como escrever código Go",
                    Author = "Golang",
                    Translator = "Viliam",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@viliamjr/como-escrever-codigo-go-95381b84ba82",
                    ImageUrl = "https://image.ibb.co/dAMfHw/47.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 48,
                    Title = "As 5 Regras da Programação - Segundo Rob Pike",
                    Author = "Rob Pike",
                    Translator = "Viliam",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@viliamjr/as-5-regras-da-programacao-segundo-rob-pike-ae3c8b599f50",
                    ImageUrl = "https://image.ibb.co/jMZpAG/48.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 49,
                    Title = "Como dar um treinamento de segurança digital",
                    Author = "Rachel Weidinger, Cooper Quintin, Martin Shelton e Matt Mitchell",
                    Translator = "Narrira Lemos",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@narriral/como-dar-um-treinamento-de-seguran%C3%A7a-digital-48c1df2f0b35",
                    ImageUrl = "https://image.ibb.co/e94pAG/49.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 50,
                    Title = "Aprenda lua em 15 minutos",
                    Author = "Corona Labs",
                    Translator = "Júnior Pires",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@junior_pires/saaripar-valida%C3%A7%C3%A3o-de-campos-no-android-9d35821a493d",
                    ImageUrl = "https://image.ibb.co/cx79AG/50.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 51,
                    Title = "Como usar o GitHub como um ser humano adequado",
                    Author = "Daniel Gallegos",
                    Translator = "Juliano Padilha",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@julianopadilha/como-usar-o-github-como-um-ser-humano-adequado-5a0a2e1afd18",
                    ImageUrl = "https://image.ibb.co/d86Qjb/51.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 52,
                    Title = "PSR-2 pt-BR Classes",
                    Author = "PHP-Fig",
                    Translator = "Artur Afonso",
                    Language = Language.Portuguese,
                    Url = "https://blog.arturafonso.com.br/psr-2-pt-br-classes-fe332b6421fd",
                    ImageUrl = "https://image.ibb.co/iv9d4b/52.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 53,
                    Title = "Substituindo instruções de switch por objetos literais",
                    Author = "Todd Motto",
                    Translator = "Jean Carlo Nascimento",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/@osuissa/substituindo-instru%C3%A7%C3%B5es-de-switch-por-objetos-literais-93a3a78463a1",
                    ImageUrl = "https://image.ibb.co/mtO5jb/53.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 54,
                    Title = "Garotas precisam de bons exemplos",
                    Author = "Dinah Davis",
                    Translator = "Andressa Chiara",
                    Language = Language.Portuguese,
                    Url = "https://code.likeagirl.io/garotas-precisam-de-bons-exemplos-5c4ba026bacf",
                    ImageUrl = "https://image.ibb.co/meo5jb/54.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 55,
                    Title = "Como os homens podem ajudar as mulheres em TI?",
                    Author = "Jonathan Howard",
                    Translator = "Marco Dubovski",
                    Language = Language.Portuguese,
                    Url = "https://code.likeagirl.io/como-os-homens-podem-ajudar-as-mulheres-em-ti-ec6f75cacdf8",
                    ImageUrl = "https://image.ibb.co/hSfJ4b/55.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 56,
                    Title = "Eloquente JavaScript",
                    Author = "Marijn Haverbeke",
                    Translator = "Eric Douglas, Saulo Santiago, Joao Stein, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/braziljs/eloquente-javascript",
                    ImageUrl = "https://image.ibb.co/gYRrPb/56.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 57,
                    Title = "The Swift Programming Language",
                    Author = "Apple",
                    Translator = "CocoaHeadsBrasil",
                    Language = Language.Portuguese,
                    Url = "https://github.com/CocoaHeadsBrasil/the-swift-programming-language-in-portuguese-br",
                    ImageUrl = "https://image.ibb.co/kn6Ecw/57.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 58,
                    Title = "Padrões de Projeto JavaScript",
                    Author = "Addy Osmani",
                    Translator = "Eric Oliveira",
                    Language = Language.Portuguese,
                    Url = "https://github.com/fhferreira/aprendendo-padroes-de-projeto-javascript",
                    ImageUrl = "https://image.ibb.co/jeC9AG/58.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 59,
                    Title = "Why's (Poignant) Guide to Ruby",
                    Author = "Mislav Marohnić",
                    Translator = "Carlos Brando, Hugo Borges, Marcos Piccinini, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/carlosbrando/poignant-br",
                    ImageUrl = "https://image.ibb.co/n1aUAG/59_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 60,
                    Title = "Pense em Python",
                    Author = "Allen B. Downey",
                    Translator = "Diego Rocha, Luciano Ramalho e Wellington Moraes",
                    Language = Language.Portuguese,
                    Url = "https://github.com/PenseAllen/PensePython2e",
                    ImageUrl = "https://image.ibb.co/iY2nxw/60_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 61,
                    Title = "Learn You Node",
                    Author = "Node School",
                    Translator = "Lucas Fernandes da Costa, Eric Douglas, Lucas Vieira, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/lucasfcosta/learnyounode-pt-br",
                    ImageUrl = "https://image.ibb.co/dAjd4b/61_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 62,
                    Title = "Learning JavaScript Design Patterns",
                    Author = "Addy Osmani",
                    Translator = "Eliel das Virgens Santos",
                    Language = Language.Portuguese,
                    Url = "https://github.com/hc3/essencial-js-padroes-de-projeto",
                    ImageUrl = "https://image.ibb.co/jMs9AG/62_OK.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 63,
                    Title = "Sinatra Book",
                    Author = "Chris Schneider",
                    Translator = "Tailor Fontela e Giovani Generali",
                    Language = Language.Portuguese,
                    Url = "https://github.com/taylorrf/sinatra-book-pt-br",
                    ImageUrl = "https://image.ibb.co/dfU0Hw/63.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 64,
                    Title = "Guia de Estilo AngularJS",
                    Author = "John Papa",
                    Translator = "Lennon Jesus, Lucas Moreira e Bruno Wego",
                    Language = Language.Portuguese,
                    Url = "https://github.com/gilsondev/angular-styleguide-pt-br/blob/master/SUMMARY.md",
                    ImageUrl = "https://image.ibb.co/fc0kjb/64.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 65,
                    Title = "Experimente Git",
                    Author = "Code School",
                    Translator = "Gustavo Franco",
                    Language = Language.Portuguese,
                    Url = "https://github.com/mandado/Experimente-Git",
                    ImageUrl = "https://image.ibb.co/jtA7xw/65.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 66,
                    Title = "CSS Sustentável",
                    Author = "Adam Silver",
                    Translator = "Ayrton Fidélis, Gabriel Bastos e Talita Pagani",
                    Language = Language.Portuguese,
                    Url = "http://csssustentavel.com.br/",
                    ImageUrl = "https://image.ibb.co/eNL7xw/66.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 67,
                    Title = "Pycubator",
                    Author = "Noam Elfanbaum e Udi Oron",
                    Translator = "Gilson Filho, Noam Elfanbaum, James Peres, etc",
                    Language = Language.Portuguese,
                    Url = "http://df.python.org.br/pycubator/",
                    ImageUrl = "https://image.ibb.co/mxPpAG/67.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 68,
                    Title = "Making Games With Python & Pygame",
                    Author = "Al Sweigart",
                    Translator = "Iury Alves e Eduardo Saito",
                    Language = Language.Portuguese,
                    Url = "https://github.com/IuryAlves/pygame-book-translation",
                    ImageUrl = "https://image.ibb.co/gDfUAG/68_OK.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 69,
                    Title = "Aprender Haskell Será um Grande Bem Para Você",
                    Author = "Miran Lipovaca",
                    Translator = "Tailor Fontela, Bruno Soares da Silva, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/taylorrf/learnhaskell",
                    ImageUrl = "https://image.ibb.co/iY6Qjb/69_OK.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 70,
                    Title = "CSS Guideline",
                    Author = "Harry Roberts",
                    Translator = "Jhon Donavan, Lucas da Silva Trindade, Larissa Mourullo, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/GDGDuqueDeCaxias/cssguideline-translate-ptbr",
                    ImageUrl = "https://image.ibb.co/dQEBPb/70.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 71,
                    Title = "The Vala Tutorial",
                    Author = "Chris Daley",
                    Translator = "Fernando da Silva Sousa, Leonardo Lemos, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/elementary-br/the-vala-tutorial",
                    ImageUrl = "https://image.ibb.co/j6NFjb/71_OK.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 72,
                    Title = "The Django Book",
                    Author = "Nigel George",
                    Translator = "Douglas Miranda, Marcelo J. Both, Londerson, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/erichideki/djangobook",
                    ImageUrl = "https://image.ibb.co/exsLHw/72_OK.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 73,
                    Title = "PHP Standards Recommendations",
                    Author = "Matthew Weier O'Phinney",
                    Translator = "Enrico Pereira",
                    Language = Language.Portuguese,
                    Url = "https://github.com/aaoliveira/PSR_PT-BR",
                    ImageUrl = "https://image.ibb.co/jytzAG/73_OK.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 74,
                    Title = "Documentação do Jekyll",
                    Author = "Jekyll",
                    Translator = "Fernando Moreira, Raphael Barreto, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/jekyll-brasil/jekyll-brasil.github.io",
                    ImageUrl = "https://image.ibb.co/jzRajb/74.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 75,
                    Title = "Documentação do React",
                    Author = "Facebook",
                    Translator = "Willian Mano e Fabio Soares",
                    Language = Language.Portuguese,
                    Url = "https://github.com/willianmano/reactdocs-pt_br",
                    ImageUrl = "https://image.ibb.co/gnJo4b/75.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 76,
                    Title = "Documentação do Composer",
                    Author = "Composer",
                    Translator = "Nando Kstro, Alfredo Braga e Gustavo Pereira",
                    Language = Language.Portuguese,
                    Url = "https://github.com/NandoKstroNet/docs-composer-pt-br",
                    ImageUrl = "https://image.ibb.co/ju1VHw/76.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 77,
                    Title = "Prism for Xamarin Forms",
                    Author = "Prism",
                    Translator = "Angelo Luis, Ronildo N. Souza e Jonathan Braga",
                    Language = Language.Portuguese,
                    Url = "https://github.com/angelobelchior/prism-xamarin-forms",
                    ImageUrl = "https://image.ibb.co/hs7gPb/77.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 78,
                    Title = "Documentação Hexo - Template Estático em Node.js",
                    Author = "Hexo",
                    Translator = "Luciano Baraúna",
                    Language = Language.Portuguese,
                    Url = "https://github.com/lucianobarauna/dochexo",
                    ImageUrl = "https://image.ibb.co/httzAG/78.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 79,
                    Title = "Beginning Perl",
                    Author = "Simon Cozens",
                    Translator = "Blabos de Blebe, Solli Moreira, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/shonorio/beginning-perl",
                    ImageUrl = "https://image.ibb.co/eCc4cw/79.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 80,
                    Title = "PromiseJS",
                    Author = "Forbes Lindesay",
                    Translator = "Pedro Nauck, Eric Douglas, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/pedronauck/promiseJS.br",
                    ImageUrl = "https://image.ibb.co/jyycxw/80.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 81,
                    Title = "Sabedoria do Elefante (Wisdom of the ElePHPant)",
                    Author = "Jeff Carouth",
                    Translator = "Reginaldo Junior e Vitor Capretz",
                    Language = Language.Portuguese,
                    Url = "https://github.com/reginaldojunior/wisdom-of-the-elephant",
                    ImageUrl = "https://image.ibb.co/iadcxw/81.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Books
                },
                new
                {
                    Id = 82,
                    Title = "Laravel 4 Docs",
                    Author = "Taylor Otwel",
                    Translator = "Kaio Cesar",
                    Language = Language.Portuguese,
                    Url = "https://github.com/kaiocesar/laravel4-docs-ptbr",
                    ImageUrl = "https://image.ibb.co/fGWajb/82.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 83,
                    Title = "Open Source Guides",
                    Author = "Github",
                    Translator = "Fernando Moreira",
                    Language = Language.Portuguese,
                    Url = "https://github.com/nandomoreirame/open-source-guide",
                    ImageUrl = "https://image.ibb.co/mp4Hxw/83.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 84,
                    Title = "Google Interview University",
                    Author = "John Washam",
                    Translator = "Marlon Aviz",
                    Language = Language.Portuguese,
                    Url = "https://github.com/avizmarlon/google-interview-university",
                    ImageUrl = "https://image.ibb.co/cxR84b/84.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 85,
                    Title = "Guia de Edição do Manual de PHP",
                    Author = "PHP Group",
                    Translator = "Anderson Mamede, Fabio Abrantes, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/phpdocbrbridge/traducao/wiki/Guia-de-edi%C3%A7%C3%A3o-do-manual",
                    ImageUrl = "https://image.ibb.co/idU6qG/85.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 86,
                    Title = "Documentação React Native",
                    Author = "Facebook",
                    Translator = "Anthony Conceição e Lorhana Trindade",
                    Language = Language.Portuguese,
                    Url = "https://github.com/AnthonyMRodrigues/docsreactnative",
                    ImageUrl = "https://image.ibb.co/eKdMPb/86.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 87,
                    Title = "Documentação - Ruby",
                    Author = "Ruby",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://www.ruby-lang.org/pt/documentation/",
                    ImageUrl = "https://image.ibb.co/fM8MPb/87.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 88,
                    Title = "Guia Definitivo para Yii 2.0",
                    Author = "Yii Software LLC",
                    Translator = "Davidson Alencar, Jan Silva, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/yiisoft/yii2/tree/master/docs/guide-pt-BR",
                    ImageUrl = "https://image.ibb.co/fzqPcw/88.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 89,
                    Title = "Documentação de PostgreSQL",
                    Author = "The PostgreSQL Global Development Group",
                    Translator = "Comunidade do PostgreSQL",
                    Language = Language.Portuguese,
                    Url = "https://www.postgresql.org.br/pages/documentacao.html",
                    ImageUrl = "https://image.ibb.co/kcOMPb/89.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 90,
                    Title = "Documentação do Bootstrap",
                    Author = "Mark Otto e Jacob",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "http://getbootstrap.com.br/",
                    ImageUrl = "https://image.ibb.co/dgVeAG/90.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 91,
                    Title = "Documentação do Symfony",
                    Author = "SensioLabs",
                    Translator = "Andréia Bohner",
                    Language = Language.Portuguese,
                    Url = "https://github.com/andreia/symfony-docs-pt-BR",
                    ImageUrl = "https://image.ibb.co/ftRKAG/91.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 92,
                    Title = "Documentação do Framework Meteor",
                    Author = "Meteor Development Group Inc.",
                    Translator = "Guilherme Decampo",
                    Language = Language.Portuguese,
                    Url = "https://github.com/MeteorBrasil/meteor-docsbr",
                    ImageUrl = "https://image.ibb.co/mCJo4b/92.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 93,
                    Title = "Documentação Respect / REST",
                    Author = "Alexandre Gomes Gaigalas",
                    Translator = "Nando Kstro, Eduardo Lopes e Eric Cristhiano",
                    Language = Language.Portuguese,
                    Url = "https://github.com/NandoKstroNet/docptbrrespectrest",
                    ImageUrl = "https://image.ibb.co/hUJAHw/93.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 94,
                    Title = "Documentação de JavaScript",
                    Author = "Mozilla",
                    Translator = "Comunidade MDN",
                    Language = Language.Portuguese,
                    Url = "https://developer.mozilla.org/pt-BR/docs/Web/JavaScript",
                    ImageUrl = "https://image.ibb.co/dcssVG/94.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 95,
                    Title = "Documentação do Respect\\Validation",
                    Author = "Alexandre Gomes Gaigalas",
                    Translator = "Nando Kstro",
                    Language = Language.Portuguese,
                    Url = "https://github.com/NandoKstroNet/docsptbrrespectvalidation",
                    ImageUrl = "https://image.ibb.co/mrTo4b/95.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 96,
                    Title = "Laravel Docs",
                    Author = "Taylor Otwel",
                    Translator = "Vinicius Reis, Leandro Sanches, Hely de Sousa, etc",
                    Language = Language.Portuguese,
                    Url = "https://github.com/artesaos/laravel-docs",
                    ImageUrl = "https://image.ibb.co/mcoAHw/96.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 97,
                    Title = "Documentação do Framework Jasmine 2.0",
                    Author = "Michael Jackson",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "http://ericdouglas.github.io/jasmine-br-docs/",
                    ImageUrl = "https://image.ibb.co/fidAHw/97.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 98,
                    Title = "Documentação do Joomla",
                    Author = "Joomla! EDL",
                    Translator = "Comunidade Joomla",
                    Language = Language.Portuguese,
                    Url = "https://docs.joomla.org/Joomla_info_page/pt-BR",
                    ImageUrl = "https://image.ibb.co/gG5eAG/98.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 99,
                    Title = "Documentação do Vue.js",
                    Author = "Evan You",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://br.vuejs.org/",
                    ImageUrl = "https://image.ibb.co/iT1KAG/99.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 100,
                    Title = "Documentação de RSCSS",
                    Author = "Rico Sta. Cruz",
                    Translator = "Mateus da Silva Sousa",
                    Language = Language.Portuguese,
                    Url = "https://silvamateus.gitbooks.io/rscss/content/",
                    ImageUrl = "https://image.ibb.co/cR8MPb/100.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 101,
                    Title = "Documentação do Jest",
                    Author = "Facebook",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "http://facebook.github.io/jest/pt-BR/",
                    ImageUrl = "https://image.ibb.co/nyuvjb/101.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 102,
                    Title = "Documentação de Lua 5.2",
                    Author = "Lua.org",
                    Translator = "Sérgio Queiroz de Medeiros e Roberto Ierusalimschy",
                    Language = Language.Portuguese,
                    Url = "https://www.lua.org/manual/5.2/pt/",
                    ImageUrl = "https://image.ibb.co/niEHxw/102.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 103,
                    Title = "Documentação do Django",
                    Author = "Django Software Foundation",
                    Translator = "Comunidade Django",
                    Language = Language.Portuguese,
                    Url = "https://docs.djangoproject.com/pt-br/1.11/",
                    ImageUrl = "https://image.ibb.co/d724cw/103.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 104,
                    Title = "Você não precisa de jQuery (Não mais)",
                    Author = "Ray Nicholus",
                    Translator = "Gabriel Ribeiro e Eric Cristhiano",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/tree/master/series/voce-nao-precisa-de-jquery",
                    ImageUrl = "https://image.ibb.co/h70CVG/104.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 105,
                    Title = "Então você quer ser um Programador Funcional?",
                    Author = "Charles Scalfani",
                    Translator = "Gabriel Ribeiro",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/tree/master/series/entao-voce-quer-ser-um-programador-funcional",
                    ImageUrl = "https://image.ibb.co/ndqCVG/105.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 106,
                    Title = "Guia Definitivo para Aprender Angularjs em 1 Dia",
                    Author = "Todd Motto",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/001-guia-definitivo-para-aprender-angularjs.md",
                    ImageUrl = "https://image.ibb.co/ieQeAG/106.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 107,
                    Title = "Aprenda AngularJS com 5 Exemplos",
                    Author = "Danny Markov",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/002-aprenda-angularjs-com-5-exemplos.md",
                    ImageUrl = "https://image.ibb.co/gcZT4b/107.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 108,
                    Title = "Use AngularJS para Potencializar suas Aplicações Web",
                    Author = "Year Of Moo",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/003-use-angularjs-para-potencializar-sua-webapp.md#use-angularjs-para-potencializar-suas-aplica%C3%A7%C3%B5es-web",
                    ImageUrl = "https://image.ibb.co/cA1mqG/108.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 109,
                    Title = "Mais Mágicas do AngularJS para Turbinar sua Webapp",
                    Author = "Year Of Moo",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/004-mais-magicas-angularjs-para-turbinar-sua-webapp.md#mais-m%C3%A1gicas-do-angularjs-para-turbinar-sua-webapp",
                    ImageUrl = "https://image.ibb.co/eNxRqG/109.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 110,
                    Title = "Entendendo Diretivas",
                    Author = "AngularJS",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/angularjs/005-entendendo-diretivas.md",
                    ImageUrl = "https://image.ibb.co/coPT4b/110.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 111,
                    Title = "Behaviour Driven Development com JavaScript",
                    Author = "Gajus Kuizinas",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/bdd/001-bdd-with-js.md",
                    ImageUrl = "https://image.ibb.co/etdAHw/111.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 112,
                    Title = "Aprenda Tudo sobre Handlebars.js Templating JavaScript",
                    Author = "Javascript is Sexy",
                    Translator = "Eric Douglas e Thulio Philipe",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/handlebars/001-aprenda-tudo-sobre-handlebars.md#aprenda-tudo-sobre-handlebarsjs-templating-javascript",
                    ImageUrl = "https://image.ibb.co/dGbxxw/112.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 113,
                    Title = "Como aprender Javascript Corretamente! – JavaScript.is (Sexy)",
                    Author = "Javascript is Sexy",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "http://javascriptissexy.com/how-to-learn-javascript-properly/",
                    ImageUrl = "https://image.ibb.co/mzL1Pb/113.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 114,
                    Title = "Objetos JavaScript em Detalhe",
                    Author = "Javascript is Sexy",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/002-objetos-js-em-detalhe.md#objetos-javascript-em-detalhe",
                    ImageUrl = "https://image.ibb.co/ieUHxw/114.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 115,
                    Title = "Escopo e Hoisting de Variáveis no JavaScript Explicados",
                    Author = "Javascript is Sexy",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/003-escopo-de-variavel-js-e-hoisting-explicado.md#escopo-de-vari%C3%A1vel-javascript-e-hoisting-explicado",
                    ImageUrl = "https://image.ibb.co/mdjjcw/115.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 116,
                    Title = "Entenda Closures no JavaScript com Facilidade",
                    Author = "Javascript is Sexy",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/004-entenda-closures-no-javaScript-com-facilidade.md#entenda-closures-no-javascript-com-facilidade",
                    ImageUrl = "https://image.ibb.co/hJycxw/116.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 117,
                    Title = "Protótipos Javascript em uma Linguagem Simples",
                    Author = "Javascript is Sexy",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/005-prototipos-javascript-em-uma-linguagem-simples.md#prot%C3%B3tipos-javascript-em-uma-linguagem-simples",
                    ImageUrl = "https://image.ibb.co/fchgPb/117.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 118,
                    Title = "Aprenda Funções JavaScript de Ordem Superior - Funções Callback",
                    Author = "Javascript is Sexy",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/006-entenda-callbacks-js.md",
                    ImageUrl = "https://image.ibb.co/k1XRqG/118.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 119,
                    Title = "Um Mergulho no JavaScript Puro",
                    Author = "Adtile Technologies Inc.",
                    Translator = "Lucas F. Costa",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/007-um-mergulho-no-javascript-puro.md",
                    ImageUrl = "https://image.ibb.co/gJYo4b/119.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 120,
                    Title = "Programação Funcional Deve Ser Sua Prioridade número #1 em 2015",
                    Author = "Ju Gonçalves",
                    Translator = "Eric Douglas e Diogo Beato",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/008-programacao-funcional-prioridade-2015.md",
                    ImageUrl = "https://image.ibb.co/kKHFjb/120.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 121,
                    Title = "Uma Suave Introdução ao JavaScript Funcional",
                    Author = "James Sinclair",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/javascript/009-uma-suave-introducao-ao-javascript-parte-1.md",
                    ImageUrl = "https://image.ibb.co/mrvPcw/121.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 122,
                    Title = "Uma introdução ao MongoDB",
                    Author = "Chris Sevilleja",
                    Translator = "Felipe Batista",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/MongoDB/001-uma-introduc%CC%A7a%CC%83o-ao-mongodb.md",
                    ImageUrl = "https://image.ibb.co/jSp6qG/122.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 123,
                    Title = "Guia Para Absolutos Iniciantes em Node.js",
                    Author = "Brandon Satrom",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/nodejs/001-guia-para-iniciantes-absolutos-em-nodejs.md",
                    ImageUrl = "https://image.ibb.co/byLqHw/123.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 124,
                    Title = "Simples Guia Passo-a-Passo Para Desenvolvedores Front-End Iniciarem Com Node.js, Express, Jade e MongoDB",
                    Author = "Christopher Buecheler",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/nodejs/002-simples-guia-nodejs-jade-express-mongodb.md",
                    ImageUrl = "https://image.ibb.co/k7wVHw/124.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 125,
                    Title = "Sua Linha do Tempo para Aprender React",
                    Author = "Dave Ceddia",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/react/01-sua-linha-do-tempo-para-aprender-react.md",
                    ImageUrl = "https://image.ibb.co/mmNFjb/125.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 126,
                    Title = "Introdução ao React para pessoas que sabem apenas o suficiente de jQuery para sobreviver",
                    Author = "Robin Rendle",
                    Translator = "Eric Douglas",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ericdouglas/traduz-ai/blob/master/react/02-introducao-ao-react-para-pessoas-que-sabem-apenas-jquery.md",
                    ImageUrl = "https://image.ibb.co/k2c4cw/126.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 127,
                    Title = "Por que VOCÊ deve escolher Python?",
                    Author = "Naomi Ceder",
                    Translator = "Débora Azevedo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/nossa-coletividad/por-que-voc%C3%AA-deve-escolher-python-ad187b9783d0",
                    ImageUrl = "https://image.ibb.co/i7QCVG/127.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 128,
                    Title = "Como instalar o pip para gerenciar pacotes do Python no GNU/Linux",
                    Author = "Aaron Kili",
                    Translator = "Allythy",
                    Language = Language.Portuguese,
                    Url = "https://allythy.github.io/Como-instalar-o-pip-para-gerenciar-pacotes-do-Python-no-GNU-Linux",
                    ImageUrl = "https://image.ibb.co/n7OMPb/128.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 129,
                    Title = "Documentação do Python",
                    Author = "Python Software Foundation",
                    Translator = "Comunidade Python",
                    Language = Language.Portuguese,
                    Url = "https://www.python.org/doc/",
                    ImageUrl = "https://image.ibb.co/kTr84b/129.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 130,
                    Title = "Como Pensar Como um Cientista da Computação",
                    Author = "Brad Miller e David Ranum",
                    Translator = "USP - Universidade de São Paulo",
                    Language = Language.Portuguese,
                    Url = "https://panda.ime.usp.br/pensepy/static/pensepy/index.html",
                    ImageUrl = "https://image.ibb.co/eZg84b/130.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 131,
                    Title = "A comunidade global de PHP continua se intoxicando, e precisamos reverter isso antes que afete outros de nós",
                    Author = "Neal Brooks",
                    Translator = "William Oliveira",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/a-comunidade-global-de-php-continua-se-intoxicando-e-precisamos-reverter-isso-antes-que-afete-da50ee793f8b",
                    ImageUrl = "https://image.ibb.co/ncGQh6/131.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 132,
                    Title = "Documentação do ReactJs",
                    Author = "Facebook",
                    Translator = "Rafael Vianna e Gabriel Pireda",
                    Language = Language.Portuguese,
                    Url = "https://github.com/rafaelvianna/ReactJs-Docs-PT-BR",
                    ImageUrl = "https://image.ibb.co/bHm7P6/132.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 133,
                    Title = "Laravel: Testando Parcialmente Respostas JSON",
                    Author = "Eric L. Barnes",
                    Translator = "Lucas Pires",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/laravel-testando-parcialmente-respostas-json-320c6dc267d7",
                    ImageUrl = "https://image.ibb.co/gfUrHR/133.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 134,
                    Title = "Como Usar Variáveis CSS",
                    Author = "ZingChart",
                    Translator = "Larissa Mourullo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/como-usar-vari%C3%A1veis-css-29b5b980794c",
                    ImageUrl = "https://image.ibb.co/ntanrm/134.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 135,
                    Title = "CSS e 5 Erros Que Você Deve Evitar",
                    Author = "Alex Devero",
                    Translator = "Larissa Mourullo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/css-e-5-erros-que-voc%C3%AA-deve-evitar-91b9872f63f4",
                    ImageUrl = "https://image.ibb.co/maw2rm/135.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 136,
                    Title = "Tutorial Angular para Iniciantes",
                    Author = "ngGirls",
                    Translator = "ngGirls",
                    Language = Language.Portuguese,
                    Url = "https://github.com/ng-girls/todo-list-tutorial-portuguese",
                    ImageUrl = "https://image.ibb.co/jxW7P6/136.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 137,
                    Title = "Guia de Código do @mdo",
                    Author = "Mark Otto",
                    Translator = "Diego Eis",
                    Language = Language.Portuguese,
                    Url = "http://diegoeis.github.io/code-guide/",
                    ImageUrl = "https://image.ibb.co/ku9K46/137.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 138,
                    Title = "CSS Idiomático",
                    Author = "Nicolas Gallagher",
                    Translator = "Zeno Rocha",
                    Language = Language.Portuguese,
                    Url = "https://github.com/necolas/idiomatic-css/blob/master/translations/pt-BR/README.md",
                    ImageUrl = "https://image.ibb.co/fcFWHR/138.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 139,
                    Title = "Como ser* um compilador - Faça um compilador com JavaScript",
                    Author = "Mariko Kosaka",
                    Translator = "Caique Hitoshi Mitsuoka",
                    Language = Language.Portuguese,
                    Url = "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/como-ser-um-compilador--faca-um-compilador-com-javascript/artigo.md",
                    ImageUrl = "https://image.ibb.co/c5VTWm/139.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 140,
                    Title = "A promessa de uma festa do hambúrguer",
                    Author = "Mariko Kosaka",
                    Translator = "Caique Hitoshi Mitsuoka",
                    Language = Language.Portuguese,
                    Url = "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/promessa-festa-hamburguer/artigo.md",
                    ImageUrl = "https://image.ibb.co/b1KfBm/140.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 141,
                    Title = "JavaScript para Gatos",
                    Author = "Max Ogden",
                    Translator = "Carolina Pascale Campos",
                    Language = Language.Portuguese,
                    Url = "https://github.com/entrylvl/traducoes-de-artigos/blob/5eac7f0977fa3c669c521ae9a39f8e1faffb6627/javascript/javascript-para-gatos.md",
                    ImageUrl = "https://image.ibb.co/dNr5cR/141.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 142,
                    Title = "Vale a pena aprender Vanilla JS? Claro!",
                    Author = "David Kopal",
                    Translator = "Marina Limeira",
                    Language = Language.Portuguese,
                    Url = "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/vale-a-pena-aprender-vanillajs--com-certeza.md",
                    ImageUrl = "https://image.ibb.co/mQOe46/142.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 143,
                    Title = "Tratando uma resposta AJAX em Javascript (com ou sem jQuery)",
                    Author = "Matt Lunn",
                    Translator = "Matheus",
                    Language = Language.Portuguese,
                    Url = "https://github.com/entrylvl/traducoes-de-artigos/blob/master/javascript/tratando-respostas-ajax-com-ou-sem-jquery.md",
                    ImageUrl = "https://image.ibb.co/gahxP6/143.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 144,
                    Title = "O que é controle de versão",
                    Author = "Atlassian",
                    Translator = "Phillip Nunes",
                    Language = Language.Portuguese,
                    Url = "https://github.com/entrylvl/traducoes-de-artigos/blob/master/git/o-que-e-controle-de-versao.md",
                    ImageUrl = "https://image.ibb.co/f3qR1m/144.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 145,
                    Title = "O que é Git?",
                    Author = "Atlassian",
                    Translator = "Will Soares e Carolina Pascale Campos",
                    Language = Language.Portuguese,
                    Url = "https://github.com/entrylvl/traducoes-de-artigos/blob/master/git/o-que-e-git.md",
                    ImageUrl = "https://image.ibb.co/gXgS7R/145.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 146,
                    Title = "Dica de CSS: Use :not para economizar tempo e linhas de código",
                    Author = "Timothy B. Smith",
                    Translator = "Larissa Mourullo",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/dica-css-use-not-para-economizar-tempo-e-linhas-de-c%C3%B3digo-3cc16468d42f",
                    ImageUrl = "https://image.ibb.co/fpiaun/146.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 147,
                    Title = "FSearch",
                    Author = "Christian Boxdörfer",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://hosted.weblate.org/engage/fsearch/?utm_source=widget",
                    ImageUrl = "https://image.ibb.co/duXeLS/147.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 148,
                    Title = "DuckDuckGo",
                    Author = "Gabriel Weinberg",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://duck.co/translate",
                    ImageUrl = "https://image.ibb.co/gYWTEn/148.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 149,
                    Title = "Tutanota",
                    Author = "-",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://tutanota.com/blog/posts/tutanota-translation-project",
                    ImageUrl = "https://image.ibb.co/iETx77/149.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 150,
                    Title = "Ring",
                    Author = "Savoir-faire Linux Inc.",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://ring.cx/en/contribute/translate",
                    ImageUrl = "https://image.ibb.co/iPPOEn/150.png",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Others
                },
                new
                {
                    Id = 151,
                    Title = "Querido Designer Jr.",
                    Author = "Elliot Dahl",
                    Translator = "Pri Barella",
                    Language = Language.Portuguese,
                    Url = "https://code.likeagirl.io/querido-designer-jr-91e67c8950af",
                    ImageUrl = "https://image.ibb.co/mpc777/151.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 152,
                    Title = "As diferenças entre SQL e NoSQL: MySQL x MongoDB",
                    Author = "XplentyBlog",
                    Translator = "Lauren Ferreira",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/diferencas-entre-sql-e-nosql-51311f9069bd",
                    ImageUrl = "https://image.ibb.co/nMOrZn/152.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 153,
                    Title = "Como se tornar um super ninja aprendiz de programação",
                    Author = "Marcus Gardiner",
                    Translator = "Vitor Martins",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/como-se-tornar-um-super-ninja-aprendiz-de-programação-b51f2488f96c",
                    ImageUrl = "https://image.ibb.co/fCvG0S/153.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 154,
                    Title = "Grafos fantásticos e onde habitam: uma introdução à teoria dos grafos",
                    Author = "Vaidehi Joshi",
                    Translator = "Lauren Ferreira",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/grafos-fant%C3%A1sticos-e-onde-habitam-uma-introdu%C3%A7%C3%A3o-%C3%A0-teoria-dos-grafos-a7f9d737d5d2",
                    ImageUrl = "https://image.ibb.co/gii0un/154.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 155,
                    Title = "Documentação do Electron",
                    Author = "Electron",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://electronjs.org/docs?lang=pt-BR",
                    ImageUrl = "https://impactotecno.files.wordpress.com/2018/02/electron1.jpg?w=640",
                    Status = TranslationStatus.InProgress,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 156,
                    Title = "Documentação do Vuex",
                    Author = "Vuex",
                    Translator = "-",
                    Language = Language.Portuguese,
                    Url = "https://vuex.vuejs.org/ptbr/",
                    ImageUrl = "https://i.ibb.co/qYL9Wzr/156.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Documentation
                },
                new
                {
                    Id = 157,
                    Title = "O que você está esperando para falar em público?",
                    Author = "Arianne Donoghue",
                    Translator = "Lauren Ferreira ",
                    Language = Language.Portuguese,
                    Url = "https://medium.com/devtranslate/o-que-voc%C3%AA-t%C3%A1-esperando-para-falar-em-p%C3%BAblico-f75d12df1355",
                    ImageUrl = "https://i.ibb.co/wrf0jBc/157.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 158,
                    Title = "Programming Doesn’t Require Talent or Even Passion",
                    Author = "Tony You",
                    Translator = "Modmaj",
                    Language = Language.English,
                    Url = "https://medium.com/@WordcorpGlobal/programming-doesnt-require-talent-or-even-passion-11422270e1e4",
                    ImageUrl = "https://image.ibb.co/h9WOkG/29.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Articles
                },
                new
                {
                    Id = 159,
                    Title = "Front End Career",
                    Author = "William Oliveira",
                    Translator = "William Oliveira, Bruno Silva, Ricardo Shiota Yasuda, Gabriel Brito, Danilo Vaz",
                    Language = Language.English,
                    Url = "https://github.com/woliveiras/front-end-career/tree/master/translations/en",
                    ImageUrl = "https://image.ibb.co/jjgfHw/40.png",
                    Status = TranslationStatus.Completed,
                    Type = TranslationType.Others,
                }
            );
        }
    }
}
