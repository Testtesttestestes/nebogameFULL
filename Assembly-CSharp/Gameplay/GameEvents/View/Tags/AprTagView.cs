using System;
using System.Runtime.CompilerServices;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.Aprs.View;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace Gameplay.GameEvents.View.Tags
{
	// Token: 0x02000783 RID: 1923
	[Token(Token = "0x2000783")]
	public class AprTagView : AprView
	{
		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x00008D18 File Offset: 0x00006F18
		// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CB")]
		public uint MedalId
		{
			[Token(Token = "0x6002DC1")]
			[Address(RVA = "0x7E3F", Offset = "0x7E3F", VA = "0x7E3F")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6002DC2")]
			[Address(RVA = "0x7E40", Offset = "0x7E40", VA = "0x7E40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008CC")]
		public string AssetId
		{
			[Token(Token = "0x6002DC3")]
			[Address(RVA = "0x7E41", Offset = "0x7E41", VA = "0x7E41")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DC4")]
			[Address(RVA = "0x7E42", Offset = "0x7E42", VA = "0x7E42")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC5")]
		[Address(RVA = "0x7E43", Offset = "0x7E43", VA = "0x7E43", Slot = "27")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerClick ---
		void Gameplay_GameEvents_View_Tags_AprTagView__OnPointerClick
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  if (*(int *)(param1 + 0x60) == 0) {
		    Gameplay_Aprs_View_AprView__HandleDataChanged(param1,param2,0);
		    return;
		  }
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId
		            (*(undefined4 *)(param1 + 0x24),*(int *)(param1 + 0x60),0);
		  return;
		}
		*/

		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC6")]
		[Address(RVA = "0x7E44", Offset = "0x7E44", VA = "0x7E44", Slot = "26")]
		protected override void SetAsset(AprDicWrapper data)
		{
		/* --- GHIDRA: SetAsset ---
		void Gameplay_GameEvents_View_Tags_AprTagView__SetAsset(int param1,undefined4 param2)
		
		{
		  UI_AbstractDeferredRenderer__OnDisable(param1,0);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId(*(undefined4 *)(param1 + 0x24),0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC7")]
		[Address(RVA = "0x7E45", Offset = "0x7E45", VA = "0x7E45", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DC8")]
		[Address(RVA = "0x7E46", Offset = "0x7E46", VA = "0x7E46")]
		public AprTagView()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_AssetId ---
		void Gameplay_GameEvents_View_Tags_AprTagView__set_AssetId
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  int param2_00;
		  
		  if (DAT_ram_00a574a1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Dict_DictWrappers_Base_AbstractDictWrapper_AprDic__uint__get_Data__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a574a1 = '\x01';
		  }
		  if (param1[0x16] != 0) {
		    Gameplay_Aprs_View_AprView__Dispose(param1,param2,0);
		    return;
		  }
		  uVar1 = 0;
		  param1_01 = (int *)param1[0x14];
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x138);
		        goto code_r0x80d8f371;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xf);
		code_r0x80d8f371:
		  param1_00 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  param2_00 = param1[0x17];
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Core_Gameplay_Managers_AprsManager__Deinit(param1_00,param2_00,*(undefined4 *)(iVar3 + 0x10),0);
		  return;
		}
		*/

}
