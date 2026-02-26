using System;
using Gameplay.Medals.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	public class MedalRewardRenderer : AbstractRewardRender
	{
		// Token: 0x06000B99 RID: 2969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x5EB2", Offset = "0x5EB2", VA = "0x5EB2", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x5EB3", Offset = "0x5EB3", VA = "0x5EB3")]
		public MedalRewardRenderer()
		{
		/* --- GHIDRA: .ctor ---
		undefined4 UI_Rewards_Renderers_MedalRewardRenderer___ctor(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59a32 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_TitleIconLoaderValueRow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a59a32 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  iVar1 = func_ii_3812(uVar2,0,0);
		  if (iVar1 == 0) {
		    return *(undefined4 *)(param1 + 0x28);
		  }
		  uVar2 = func_ii_5677(param1,Method_UnityEngine_Component_GetComponent_TitleIconLoaderValueRow___);
		  *(undefined4 *)(param1 + 0x28) = uVar2;
		  return uVar2;
		}
		*/

		}

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MedalView _medalViewPrefab;
	}
}
