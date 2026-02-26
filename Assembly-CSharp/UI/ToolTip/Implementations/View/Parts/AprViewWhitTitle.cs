using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.ToolTip.Implementations.View.Parts
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public class AprViewWhitTitle : AbstractDataRenderer<AprDicWrapper>, IAprView
	{
		// Token: 0x060009BB RID: 2491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x5D23", Offset = "0x5D23", VA = "0x5D23")]
		private void Start()
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x5D24", Offset = "0x5D24", VA = "0x5D24")]
		public void SetTitle(string value)
		{
		/* --- GHIDRA: SetTitle ---
		void UI_ToolTip_Implementations_View_Parts_AprViewWhitTitle__SetTitle(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  
		  piVar2 = (int *)param1[9];
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x138) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x13c));
		  return;
		}
		*/

		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x5D25", Offset = "0x5D25", VA = "0x5D25", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void UI_ToolTip_Implementations_View_Parts_AprViewWhitTitle__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59974 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_AprDicWrapper___ctor__);
		    DAT_ram_00a59974 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_AprDicWrapper___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x5D26", Offset = "0x5D26", VA = "0x5D26")]
		public AprViewWhitTitle()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		UI_ToolTip_Implementations_View_Parts_AprViewWhitTitle___ctor(int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  iVar2 = **(int **)(param1 + 0x48);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		                    (*(int **)(param1 + 0x48),*(undefined4 *)(iVar2 + 0x134));
		  return uVar1;
		}
		*/

		}

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private AprViewSmall _aprView;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _subTitle;
	}
}
