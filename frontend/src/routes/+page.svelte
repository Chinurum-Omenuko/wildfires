<script lang="ts">
    import { onMount } from "svelte";
    import Wheel from "../icons/loading/wheel.svg"
    let loading = true;

	import Marker from "../components/MapComps/Marker.svelte";
    import Map from "../components/MapComps/Map.svelte";

    import type { LatLngExpression } from "leaflet";
    const initialView: LatLngExpression = [40.762455202564354, -65.0496827046608];

    export let data;
</script>

<main>
    <h1>Map</h1>
    <Map view={initialView} zoom={2}>
        {#each data.fires as fire}
            <Marker width={20} height={20} lat={fire.coordinates[0]} long={fire.coordinates[1]}/>
        {/each}
    </Map>
</main>

<style lang="scss">
    main{
        min-height: 100vh;
    }
    
</style>