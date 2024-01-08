from rest_framework.response import Response
from rest_framework.views import APIView
from rest_framework import generics
from .models import Report
from .serializers import ReportSerializer



# Create your views here.
class ReportView(APIView):
  def get(self, request):
     reports = Report.objects.all()
     serializer = ReportSerializer(reports, many=True)
     print(serializer.data)
     return Response(serializer.data)

  def post(self, request):
      serializer = ReportSerializer(data=request.data)
      if serializer.is_valid():
          serializer.save() # This line saves the data to the database
          return Response(serializer.data, status=201)
      return Response(serializer.errors, status=400)