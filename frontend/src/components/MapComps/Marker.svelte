<script lang="ts">
	import * as L from "leaflet";
	import { getContext, onDestroy, onMount, setContext } from "svelte";
    import flame from '../../icons/fire/output-onlinegiftools.gif';
    let marker: L.Marker | undefined;
    let markerContainer: HTMLElement;
    export let width: number, height: number;
    export let long: number, lat: number;

    let fire = L.icon({
    iconUrl: flame,
    iconSize:     [48, 95], // size of the icon
    shadowSize:   [50, 64], // size of the shadow
    iconAnchor:   [22, 94], // point of the icon which will correspond to marker's location
    shadowAnchor: [4, 62],  // the same for the shadow
    popupAnchor:  [-3, -76] // point from which the popup should open relative to the iconAnchor
});

    interface mapContext {
        getMap: () => L.Map | undefined
    }

    const map = getContext<mapContext>('map')?.getMap()

    setContext('layer', 
    {
        getLayer: () => marker
    });
    
    onMount( () => {
        if (map){
            marker = L.marker([long, lat],{icon: fire}).addTo(map)
        }
    });

    onDestroy( () => {
        marker?.remove();
        marker = undefined;
    });
</script>

<div bind:this={markerContainer} class="marker">
    {#if marker}
        <slot />
    {/if}
</div>

<style>
    .marker{
        background: none;
    }

</style>