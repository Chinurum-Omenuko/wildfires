<script>
// @ts-nocheck

	
    // @ts-ignore
    import Article from "../../components/NewsComps/Article.svelte";
    import NewsGrid from "../../components/NewsComps/NewsGrid.svelte";

    export let data;
    console.log(data)
</script>

<main>
    <NewsGrid>
        {#each data.filtered.slice(0,24) as newsdata}
            <Article img={newsdata.urlToImage} content={newsdata.content} title={newsdata.title}/>
        {/each}
    </NewsGrid>
    
</main>

<style lang="scss">
    main{
        padding-top: 4rem;
        background-color: black;
        color: aliceblue;
    }
</style>