import * as api from './apiService'

export const getPharmacies = async () => {
    const res = await api.get('/api/student')
    console.log(res)
    return res
}