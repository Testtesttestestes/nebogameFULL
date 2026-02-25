using System;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Application.SO
{
	// Token: 0x0200123D RID: 4669
	[Token(Token = "0x200123D")]
	[CreateAssetMenu(fileName = "AmplitudeSettings", menuName = "Heavens/Amplitude settings data scriptable object")]
	public class AmplitudeSettingsDataSO : SerializedScriptableObject
	{
		// Token: 0x06006EC4 RID: 28356 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006EC4")]
		[Address(RVA = "0xB942", Offset = "0xB942", VA = "0xB942")]
		public AmplitudeSettings GetSettingsForServer(string serverName)
		{
			return null;
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EC5")]
		[Address(RVA = "0xB943", Offset = "0xB943", VA = "0xB943")]
		public AmplitudeSettingsDataSO()
		{
		}

		// Token: 0x040039DE RID: 14814
		[Token(Token = "0x40039DE")]
		[FieldOffset(Offset = "0x2C")]
		public AmplitudeSettings[] Settings;
	}
}
