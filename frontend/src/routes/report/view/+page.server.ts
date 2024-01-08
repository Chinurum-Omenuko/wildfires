/** @type {import('./$types').PageLoad} */
export const load = async () =>{
    const response = await fetch('https://infeu.onrender.com/report/')
    const report =  response.json()
    return {report}
}