using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using System.Diagnostics;

namespace AreTrapsGay
{
	public class Program
	{
		static void Main()
		{
			Console.WriteLine("LOADING... GAYINATOR 3000");
			Console.WriteLine("(All mesurements are in cm)\n");

			GAY gay = new GAY();

			gay.Body();
			gay.Face();
			gay.Voice();
			gay.Penis();
			gay.GayPoints = gay.FacePoints + gay.BodyPoints + gay.PenisPoints + gay.VoicePoints;
			Console.WriteLine("The trap is this much gay: " + gay.GayPoints + "%" + "\n");
			Console.WriteLine("Face: " + gay.FacePoints);
			Console.WriteLine("Body: " + gay.BodyPoints);
			Console.WriteLine("Penis: " + gay.PenisPoints);
			Console.WriteLine("Voice: " + gay.VoicePoints);
			Console.ReadKey();
		}
		public class GAY
		{
			//Body
			public float waist, fWaist = 98.3f, mWaist = 102f, avgWaist;
			public float shoulders, fShoulders = 36.7f, mShoulders = 41.1f, avgShoulders;
			public float height, fHeight = 165f, mHeight = 180f, avgHeight;
			public float boobSize, fBoobs = 95f, mBoobs = 86f, avgBoobs;
			//Face
			public float forehead, fForehead = 12.2f, mForehead = 12.9f, avgForehead;
			public float width, fWidth = 15f, mWidth = 15.9f, avgWidth;
			public float length, fLength = 19.9f, mLength = 21.6f, avgLength;
			public float pupilDistance, fPupilDistance = 7f, mPupilDistance = 7.4f, avgPupilDistance;
			//Penis volume
			public float penisLength;
			public float penisRadius;
			public float avgPenisVolume = 162.11f;
			//Voice
			public float voiceHz;
			//Points
			public float GayPoints, FacePoints, BodyPoints, PenisPoints, VoicePoints;
			//-------------FillerShit---------------
			public float basePoint, basePoint1, basePoint2, basePoint3, percentOfFace, percentOfBody, PenisVolume, Difference, boobPoint;

			public void Face()
			{
				//---------------Forehead---------------------
				Console.WriteLine("Enter Forehead Length:");
				forehead = float.Parse(Console.ReadLine());

				avgForehead = forehead - fForehead;
				if (avgForehead > 0f)
				{
					basePoint = (mForehead - fForehead) / 25f;
					avgForehead = (forehead - fForehead) / basePoint;
				}
				else
				{
					avgForehead = 0f;
				}
				//---------------Width---------------------
				Console.WriteLine("Enter Face width:");
				width = float.Parse(Console.ReadLine());

				avgWidth = width - fWidth;
				if (avgWidth > 0f)
				{
					basePoint1 = (mWidth - fWidth) / 25f;
					avgWidth = (width - fWidth) / basePoint1;
				}
				else
				{
					avgWidth = 0f;
				}
				//---------------Length---------------------
				Console.WriteLine("Enter Face Length:");
				length = float.Parse(Console.ReadLine());

				avgLength = length - fLength;
				if (avgLength > 0f)
				{
					basePoint2 = (mLength - fLength) / 25f;
					avgLength = (length - fLength) / basePoint2;
				}
				else
				{
					avgLength = 0f;
				}
				//---------------Pupils---------------------
				Console.WriteLine("Enter distance from pupils:");
				pupilDistance = float.Parse(Console.ReadLine());

				avgPupilDistance = pupilDistance - fPupilDistance;
				if (avgPupilDistance > 0f)
				{
					basePoint3 = (mPupilDistance - fPupilDistance) / 25f;
					avgPupilDistance = (pupilDistance - fPupilDistance) / basePoint3;
				}
				else
				{
					avgPupilDistance = 0f;
				}
				//---------------Adding everything up---------------------
				percentOfFace = (avgLength + avgWidth + avgForehead + avgPupilDistance);
				FacePoints = 25f * (percentOfFace / 100);

			}
			public void Body()
			{
				//---------------Waist---------------------
				Console.WriteLine("Enter Waist size:");
				waist = float.Parse(Console.ReadLine());

				avgWaist = waist - fWaist;
				if (avgWaist > 0f)
				{
					basePoint = (mWaist - fWaist) / 33.3f;
					avgWaist = (waist - fWaist) / basePoint;
				}
				else
				{
					avgWaist = 0f;
				}
				//---------------Shoulders---------------------
				Console.WriteLine("Enter Shoulder Length:");
				shoulders = float.Parse(Console.ReadLine());

				avgShoulders = shoulders - fShoulders;
				if (avgShoulders > 0f)
				{
					basePoint1 = (mShoulders - fShoulders) / 33.3f;
					avgShoulders = (shoulders - fShoulders) / basePoint1;
				}
				else
				{
					avgShoulders = 0f;
				}
				//---------------Height---------------------
				Console.WriteLine("Enter Height:");
				height = float.Parse(Console.ReadLine());

				avgHeight = height - fHeight;
				if (avgHeight > 0f)
				{
					basePoint2 = (mHeight - fHeight) / 33.3f;
					avgHeight = (height - fHeight) / basePoint2;
				}
				else
				{
					avgHeight = 0f;
				}
				//---------------Boobs---------------------
				Console.WriteLine("Enter Bust size:");
				boobSize = float.Parse(Console.ReadLine());

				avgBoobs = boobSize - mBoobs;
				if (avgBoobs > 0f)
				{
					boobPoint = (fBoobs - mBoobs) / 33.3f;
					avgHeight = (mBoobs - boobSize) / boobPoint;
					Math.Abs(avgHeight);
				}
				else
				{
					avgBoobs = 0f;
				}
				//---------------Adding everything up---------------------
				percentOfBody = (avgWaist + avgHeight + avgShoulders - avgBoobs);
				BodyPoints = 25f * (percentOfBody / 100);

			}
			public void Penis()
			{
				Console.WriteLine("Enter Penis Length:");
				penisLength = float.Parse(Console.ReadLine());
				Console.WriteLine("Enter Penis Radius:");
				penisRadius = float.Parse(Console.ReadLine()); //Gets the values

				PenisVolume = 3.14f * (penisRadius * penisRadius) * penisLength;
				Difference = PenisVolume - avgPenisVolume;
				if (Difference > 0)
				{
					basePoint = avgPenisVolume / 25f;
					PenisPoints = PenisVolume / basePoint; //This is probably correct
				}
				else
				{
					PenisPoints = 0;
				}
			}
			public void Voice()
			{
				Console.WriteLine("Enter Voice Pitch in Hz:");
				voiceHz = float.Parse(Console.ReadLine()); //Gets the values

				if (voiceHz <= 255f)
				{
					if (voiceHz > 165f)
					{
						VoicePoints = 0f;
					}
				}
				else
				{
					basePoint = 85f - 165f / 25f;
					VoicePoints = voiceHz - 165f / basePoint;
				}
			}
		}
	}
}
