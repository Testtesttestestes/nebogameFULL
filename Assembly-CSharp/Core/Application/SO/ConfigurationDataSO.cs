using System;
using Core.Gameplay.Managers.Configuration;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Core.Application.SO
{
	// Token: 0x02001240 RID: 4672
	[Token(Token = "0x2001240")]
	[CreateAssetMenu(fileName = "ConfigurationDataConfig", menuName = "Heavens/Configuration Data Config for Target Platform")]
	public class ConfigurationDataSO : SerializedScriptableObject
	{
		// Token: 0x06006ECD RID: 28365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006ECD")]
		[Address(RVA = "0xB94B", Offset = "0xB94B", VA = "0xB94B")]
		public ConfigurationDataSO()
		{
		}

		// Token: 0x040039E4 RID: 14820
		[Token(Token = "0x40039E4")]
		[FieldOffset(Offset = "0x2C")]
		public ConfigRecord Record;

		// Token: 0x040039E5 RID: 14821
		[Token(Token = "0x40039E5")]
		[FieldOffset(Offset = "0x30")]
		public LaunchAppVars LaunchAppVars;
	}
}
