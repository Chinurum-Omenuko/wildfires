<script lang="ts">
	import ReportCard from "../../../components/ReportComps/ReportCard.svelte";
    export let data;
</script>

<section>

    {#each data.report as report}
        <ReportCard name={report.name} report={report.report}/>
    {/each}
</section>

<style>
    p{
        color: white;
    }

    section{
        display: grid;
        place-items: center;
        padding-top: 4rem;
        row-gap: 4rem;
    }
</style>