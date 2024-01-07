<script lang="ts">
    import { page } from "$app/stores";
</script>

<div class="navbar bg-black nav">
    <div class="flex-1 d-flex flex-row justify-between items-center">
      <!-- svelte-ignore a11y-missing-attribute -->
      <a class="btn btn-ghost text-xl">Infeu</a>
      <div class="page"><h2>{
        $page.url.pathname === "/" ? "Map" :
        $page.url.pathname === "/news" ? "News" :
        $page.url.pathname === "/report" ? "Report" : ""
    }</h2></div>
    </div>
    
</div>


<style>
    .nav{
        position: fixed;
        z-index: 1000;
    }
</style>