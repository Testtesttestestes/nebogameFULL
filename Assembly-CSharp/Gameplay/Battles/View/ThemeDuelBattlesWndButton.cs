using System;
using AssetContent.Loaders;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Battles.View
{
	// Token: 0x02000C2B RID: 3115
	[Token(Token = "0x2000C2B")]
	public sealed class ThemeDuelBattlesWndButton : BattlesWndButton
	{
		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06004BF8 RID: 19448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F51")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6004BF8")]
			[Address(RVA = "0x9A3C", Offset = "0x9A3C", VA = "0x9A3C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06004BF9 RID: 19449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F52")]
		public GameRawImageLoader ImageLoader
		{
			[Token(Token = "0x6004BF9")]
			[Address(RVA = "0x9A3D", Offset = "0x9A3D", VA = "0x9A3D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BFA")]
		[Address(RVA = "0x9A3E", Offset = "0x9A3E", VA = "0x9A3E")]
		public ThemeDuelBattlesWndButton()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Battles_View_ThemeDuelBattlesWndButton___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param6,0);
		  *(undefined4 *)(param1 + 0x14) = param5;
		  *(undefined4 *)(param1 + 0x10) = param4;
		  *(undefined4 *)(param1 + 0xc) = param3;
		  *(undefined4 *)(param1 + 0x18) = param2;
		  return;
		}
		*/

		}

		// Token: 0x04002962 RID: 10594
		[Token(Token = "0x4002962")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private GameRawImageLoader _imageLoader;

		// Token: 0x04002963 RID: 10595
		[Token(Token = "0x4002963")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _title;
	}
}
