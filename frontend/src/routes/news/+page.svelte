<script lang="ts">
	import { setContext } from "svelte";
// @ts-nocheck
    // @ts-ignore
    import Article from "../../components/NewsComps/Article.svelte";
    import NewsGrid from "../../components/NewsComps/NewsGrid.svelte";

    interface News {
        source : string,
        author: string,
        title: string,
        description : string,
        url: string,
        urlToImage: string,
        publishedAt: string,
        content: string,

    } 

    export let data;

    console.log(data)
</script>

<main>
    <NewsGrid>
        {#each data.props.filtered.slice(0,24) as newsdata}
            <Article img={newsdata.urlToImage} content={newsdata.content} title={newsdata.title} url={newsdata.url}/>
        {/each}
    </NewsGrid>
    
</main>

<style lang="scss">
    main{
        padding-top: 4rem;
        background-color: black;
        color: aliceblue;

        a{
            border: solid 2px red;
        }
    }
</style>