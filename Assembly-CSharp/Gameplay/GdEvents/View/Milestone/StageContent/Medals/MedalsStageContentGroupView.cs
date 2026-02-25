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
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x7C6A", Offset = "0x7C6A", VA = "0x7C6A")]
		public MedalsStageContentGroupView()
		{
		}

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private MedalView _medalPrefab;
	}
}
