export const ssr = false


/** @type {import('./$types').PageServerLoad} */
export const load = async () => {
    const res = await fetch('http://127.0.0.1:8000/map/')
    const fires = await res.json()
    console.log(fires)
    return { fires }
    
    

}