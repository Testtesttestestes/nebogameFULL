using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Application.SO
{
	// Token: 0x02001246 RID: 4678
	[Token(Token = "0x2001246")]
	[CreateAssetMenu(fileName = "LevelPlaySettings", menuName = "Heavens/LevelPlay Settings")]
	public class LevelPlaySettingsDataSO : SerializedScriptableObject
	{
		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06006EDF RID: 28383 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016A0")]
		public LevelPlaySettings Settings
		{
			[Token(Token = "0x6006EDF")]
			[Address(RVA = "0xB95D", Offset = "0xB95D", VA = "0xB95D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EE0")]
		[Address(RVA = "0xB95E", Offset = "0xB95E", VA = "0xB95E")]
		public LevelPlaySettingsDataSO()
		{
		}

		// Token: 0x040039F1 RID: 14833
		[Token(Token = "0x40039F1")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LevelPlaySettings _settings;
	}
}
