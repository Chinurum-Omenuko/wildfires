# Create your views here.
from rest_framework import generics
import httpx
from django.http import JsonResponse
from json.decoder import JSONDecodeError

async def get_event(request):
  url = "https://eonet.gsfc.nasa.gov/api/v3/events?category=wildfires"
  async with httpx.AsyncClient() as client:
      data = await client.get(url)
      try:
       data = data.json()
       filtered_data = [
           {'location': event['title'],
            'coordinates': event['geometry'][0]['coordinates']
           }
           for event in data['events']
       ]
       
      except JSONDecodeError:
          return JsonResponse({"error": "Invalid JSON response from server"}, status=400)
      return JsonResponse(filtered_data, safe=False)
