<script lang="ts">
    export let name: string;
    export let report: string;

</script>


<div id="report" class="w-full max-w-xs p-4 text-gray-500 bg-white rounded-lg shadow dark:bg-gray-800 dark:text-gray-400" >
    <div class="flex">
        <img class="w-8 h-8 rounded-full" src="/docs/images/people/profile-picture-1.jpg" alt="Jese Leos image"/>
        <div class="ms-3 text-sm font-normal">
            <span class="mb-1 text-sm font-semibold text-gray-900 dark:text-white">{name}</span>
            <div class="mb-2 text-sm font-normal">{report}</div>   
        </div>
        
    </div>
</div>


<style>

</style>