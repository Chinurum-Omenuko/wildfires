
from django.core.cache import cache
import httpx
from django.http import JsonResponse
from json.decoder import JSONDecodeError

async def get_event(request):
 url = "https://eonet.gsfc.nasa.gov/api/v3/events?category=wildfires"
 async with httpx.AsyncClient(timeout=80) as client:
  data = cache.get(url)
  if data is None:
      
      data = await client.get(url)
      data = data.json()
      
      
      cache.set(url, data)

  try:
      filtered_data = [
          {'location': event['title'],
           'coordinates': event['geometry'][0]['coordinates']
          }
          for event in data['events']
      ]
  except JSONDecodeError:
      return JsonResponse({"error": "Invalid JSON response from server"}, status=400)

  return JsonResponse(filtered_data, safe=False)

