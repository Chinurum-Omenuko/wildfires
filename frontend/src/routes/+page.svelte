<script lang="ts">
	import Marker from "../components/MapComps/Marker.svelte";
    import Map from "../components/MapComps/Map.svelte";

    import type { LatLngExpression } from "leaflet";

    const initialView: LatLngExpression = [51.514244, 7.468429];
    export let data;
</script>

<main>
    <h1>Map</h1>
    <Map view={initialView} zoom={13}>
        {#each data.fires as fire}
            <Marker width={20} height={20} lat={fire.coordinates[0]} long={fire.coordinates[1]}/>
        {/each}
    </Map>
</main>

<style lang="scss">
    main{
        min-height: 100vh;
        border: solid 2px red;
    }
    
</style>