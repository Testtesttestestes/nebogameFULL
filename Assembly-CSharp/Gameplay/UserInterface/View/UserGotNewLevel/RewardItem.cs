using System;
using Core.Animations;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInterface.View.UserGotNewLevel
{
	// Token: 0x020003C8 RID: 968
	[Token(Token = "0x20003C8")]
	public class RewardItem : MonoBehaviour
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B7")]
		[Address(RVA = "0x6878", Offset = "0x6878", VA = "0x6878")]
		public void ShowGetReward()
		{
		/* --- GHIDRA: ShowGetReward ---
		void Gameplay_UserInterface_View_UserGotNewLevel_RewardItem__ShowGetReward
		               (int param1,float param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  param1_00 = DG_Tweening_TweenSettingsExtensions__SetLink_object_(*(undefined4 *)(param1 + 0x14),0)
		  ;
		  Core_Animations_GameSpineUiAnimation__get_SkeletonGraphic(param1_00,0.0,param2,0);
		  return;
		}
		*/

		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B8")]
		[Address(RVA = "0x6879", Offset = "0x6879", VA = "0x6879")]
		public void FadeOut(float duration)
		{
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B9")]
		[Address(RVA = "0x687A", Offset = "0x687A", VA = "0x687A")]
		public RewardItem()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_UserInterface_View_UserGotNewLevel_RewardItem___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58272 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12681);
		    DAT_ram_00a58272 = '\x01';
		  }
		  return StringLiteral_12681;
		}
		*/

		}

		// Token: 0x04000BFA RID: 3066
		[Token(Token = "0x4000BFA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CanvasGroup _content;

		// Token: 0x04000BFB RID: 3067
		[Token(Token = "0x4000BFB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameSpineUiAnimation _marker;
	}
}
