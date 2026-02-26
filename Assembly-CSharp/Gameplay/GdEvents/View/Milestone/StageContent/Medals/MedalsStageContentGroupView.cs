using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Medals
{
	// Token: 0x0200072B RID: 1835
	[Token(Token = "0x200072B")]
	public class MedalsStageContentGroupView : AbstractStageContentGroupView<MedalDicWrapper>
	{
		// Token: 0x06002BD8 RID: 11224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x7C69", Offset = "0x7C69", VA = "0x7C69", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<MedalDicWrapper> fromData, StageContentData<MedalDicWrapper> toData)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Medals_MedalsStageContentGroupView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a27e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MedalDicWrapper___ctor__
		              );
		    DAT_ram_00a5a27e = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_MedalDicWrapper___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x7C6A", Offset = "0x7C6A", VA = "0x7C6A")]
		public MedalsStageContentGroupView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Medals_MedalsStageContentGroupView___ctor
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a27f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_SocialGiftDic__TypeInfo);
		    DAT_ram_00a5a27f = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x18);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_SocialGiftDic__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_SocialGiftDic__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x18,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MedalView _medalPrefab;
	}
}
