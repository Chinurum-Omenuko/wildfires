<script>
    import fire from "../../icons/navicons/flame.svg"
    import news from "../../icons/navicons/news.svg"
    import inbox from "../../icons/navicons/inbox.svg"
</script>
<nav>
    <div class="wrapper">
        <a href="/"><img src={fire} alt=""></a>
        <a href="/news"><img src={news} alt=""></a>
        <a href="/report"><img src={inbox} alt=""></a>
    </div>
</nav>

<style lang="scss">
    nav{
        position: fixed;
        bottom: 0;
        right: 0;
        display: flex;
        flex-direction: row;
        justify-content: space-around;
        align-items: center;
        z-index: 1000;

        width: 100%;
        min-height: 5em;

        background-color: hsla(206, 93%, 52%, 0);


        a{
            
            color: hsl(27, 69%, 97%)

            
        }

        .wrapper{
            background-color: hsl(206, 26%, 5%);
            display: flex;
            flex-direction: row;
            justify-content: space-around;

            width: 20rem;

            border-radius: 30px;
            border: solid 1px rgb(163, 163, 163);
        }
    }
</style>