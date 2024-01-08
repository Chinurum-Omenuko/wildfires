<script lang="ts">
    import { goto } from "$app/navigation";
	import ReportCard from "./ReportCard.svelte";

    let name: string;
    let report: string;

    const submit = async () => {
        const url = 'http://127.0.0.1:8000/report/';
        const headers = { 'Content-Type': 'application/json' };
        const body = JSON.stringify({name, report});
        
        const postRequest = await fetch(url, {
            method: 'POST',
            headers: headers,
            body: body
        });

        name = '';
        report = '';
    }



    const viewsubmissions = () =>{
        goto('/report/view')
    }
</script>

<div class="w-full max-w-sm p-4 bg-white border border-gray-200 rounded-lg shadow sm:p-6 md:p-8 dark:bg-gray-800 dark:border-gray-700 " >
    <form class="space-y-6" on:submit|preventDefault={submit} >
        <h5 class="text-xl font-medium text-gray-900 dark:text-white">Leave a report on any potential fire sightings</h5>
        <div>
            <label for="text" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Your Name</label>
            <input type="text" name="fname" id="fname" class="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full p-2.5 dark:bg-gray-600 dark:border-gray-500 dark:placeholder-gray-400 dark:text-white" placeholder="Jane Doe" required bind:value={name}>
        </div>
        <div>
            <label for="password" class="block mb-2 text-sm font-medium text-gray-900 dark:text-white">Report</label>
            <textarea id="message" rows="4" class="block p-2.5 w-full text-sm text-gray-900 bg-gray-50 rounded-lg border border-gray-300 focus:ring-blue-500 focus:border-blue-500 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500" placeholder="Write your report here..." bind:value={report}></textarea>
        </div>
        
        <button type="submit" class="w-full text-white bg-green-700 hover:bg-green-800 focus:ring-4 focus:outline-none focus:ring-green-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center dark:bg-green-600 dark:hover:bg-green-700 dark:focus:ring-green-800">Submit Report</button>
        <button on:click={viewsubmissions} type="button" class="w-full text-white bg-blue-700 hover:bg-blue-800 focus:ring-4 focus:outline-none focus:ring-blue-300 font-medium rounded-lg text-sm px-5 py-2.5 text-center dark:bg-blue-600 dark:hover:bg-blue-700 dark:focus:ring-blue-800">View Submissions</button>
        
    </form>
</div>


