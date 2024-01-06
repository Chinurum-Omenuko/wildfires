<script lang="ts">
    import "../app.css";
	import Header from "../components/Header/Header.svelte";
	import Nav from "../components/Nav/Nav.svelte";
</script>

<Header />
<slot />
<Nav />