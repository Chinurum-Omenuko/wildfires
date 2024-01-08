export const ssr = false


/** @type {import('./$types').PageServerLoad} */
export const load = async () => {
    const res = await fetch('https://infeu.onrender.com/map/')
    const fires = await res.json()
    console.log(fires)
    return { fires }
    
    

}