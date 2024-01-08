from django.http import HttpResponse
from rest_framework.response import Response
from rest_framework.views import APIView
from rest_framework import generics
import json

# Create your views here.

import httpx


async def get_news(request):
    apiKey: str = "07dc50c8a8aa4d308e0160229117df62"
    url: str = f"https://newsapi.org/v2/everything?q=wildfires&apiKey={apiKey}"
    async with httpx.AsyncClient() as client:
        response = await client.get(url)
        data = response.json()
        filtered = [{
            'source': article['source']['name'],
            'author': article['author'],
            'title': article['title'],
            'description': article['description'],
            'url': article['url'],
            'urlToImage': article['urlToImage'],
            'publishedAt': article['publishedAt'],
            'content': article['content'],
            } for article in data['articles']]
        
        return HttpResponse(json.dumps(filtered))