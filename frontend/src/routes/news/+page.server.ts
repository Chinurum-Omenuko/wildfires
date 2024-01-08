
/** @type {import('./$types').PageServerLoad} */
export const load = async () => {
    const res = await fetch('https://infeu.onrender.com/news')
    const filtered = await res.json()
    return { props : {filtered} }
    
    

}