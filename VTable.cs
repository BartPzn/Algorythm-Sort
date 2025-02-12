﻿using projekt_sklejanie_1;

namespace Projekt3_Sortowanie.Tables
{
	class VTable : ITableGenerator
	{
		/// <summary>
		/// Generate V-shaped numbers array
		/// </summary>
		/// <param name="a_iSize">Size of array</param>
		/// <returns>V-shaped array</returns>
		public int[] GenerateTab(int a_iSize)
		{
			//inicjalizacja tablicy
			int[] _oReturn = new int[a_iSize];

			//wartość początkowa tablicy pobrana ze środka podanej wielkości
			int _iValue = a_iSize / 2;

			//pętla po tablicy
			for (int i = 0; i < a_iSize; i++)
			{
				if (i < a_iSize / 2)
					_oReturn[i] = _iValue--;
				else
					_oReturn[i] = _iValue++;
			}

			//zwrócenie tablicy
			return _oReturn;
		}
	}
}