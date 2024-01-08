/** @type {import('./$types').PageLoad} */
export const load = async () =>{
    const response = await fetch('http://127.0.0.1:8000/report/')
    const report =  response.json()
    return {report}
}