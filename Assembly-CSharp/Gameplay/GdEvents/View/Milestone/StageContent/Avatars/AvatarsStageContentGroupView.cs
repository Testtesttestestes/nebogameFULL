using System;
using Core.Dict.DictWrappers.Wrappers;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.GdEvents.View.Milestone.StageContent.Avatars
{
	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x2000730")]
	public class AvatarsStageContentGroupView : AbstractStageContentGroupView<AprDicWrapper>
	{
		// Token: 0x06002BED RID: 11245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BED")]
		[Address(RVA = "0x7C7E", Offset = "0x7C7E", VA = "0x7C7E", Slot = "4")]
		protected override void HandleDataChanged(StageContentData<AprDicWrapper> fromData, StageContentData<AprDicWrapper> toData)
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Avatars_AvatarsStageContentGroupView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a28a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_AprDicWrapper___ctor__
		              );
		    DAT_ram_00a5a28a = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,
		             Method_Gameplay_GdEvents_View_Milestone_StageContent_AbstractStageContentGroupView_AprDicWrapper___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BEE")]
		[Address(RVA = "0x7C7F", Offset = "0x7C7F", VA = "0x7C7F")]
		public AvatarsStageContentGroupView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_Milestone_StageContent_Avatars_AvatarsStageContentGroupView___ctor
		               (int param1,undefined4 param2)
		
		{
		  func_ii_14558(*(undefined4 *)(param1 + 0x18),0);
		  return;
		}
		*/

		}

		// Token: 0x0400180E RID: 6158
		[Token(Token = "0x400180E")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private AvatarView _avatarPrefab;
	}
}
