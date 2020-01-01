export const get = async (path) => {
    const response = await fetch(`${path}`, {
        method: 'GET',
    })
    console.log(path)
    return response.json()
}