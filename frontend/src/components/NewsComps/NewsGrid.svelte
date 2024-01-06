<script>

</script>

<section class="newsgallery">
    <slot></slot>
    
</section>


<style lang="scss">

    section{
        display: grid;
        grid-template-columns: repeat(3, 1fr);
        grid-auto-rows: 300px 300px;
        gap: 30px;
        margin: 0 20px;
    }
    

</style>