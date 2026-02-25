using System;
using System.Collections.Generic;
using Core.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000673 RID: 1651
	[Token(Token = "0x2000673")]
	public class ArtifactNotesView : MonoBehaviour
	{
		// Token: 0x06002800 RID: 10240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x7925", Offset = "0x7925", VA = "0x7925")]
		private void Awake()
		{
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000796")]
		public ArtifactData ArtifactData
		{
			[Token(Token = "0x6002801")]
			[Address(RVA = "0x7926", Offset = "0x7926", VA = "0x7926")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002802")]
			[Address(RVA = "0x7927", Offset = "0x7927", VA = "0x7927")]
			set
			{
			}
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x7928", Offset = "0x7928", VA = "0x7928")]
		private void OnEnable()
		{
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x7929", Offset = "0x7929", VA = "0x7929")]
		private void OnDisable()
		{
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x792A", Offset = "0x792A", VA = "0x792A")]
		private void StartListenEvents(ArtifactData artifact)
		{
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x792B", Offset = "0x792B", VA = "0x792B")]
		private void StopListenEvents(ArtifactData artifact)
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x792C", Offset = "0x792C", VA = "0x792C")]
		private void ArtifactDataOnIsMostPowerfulChangedEvent()
		{
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x792D", Offset = "0x792D", VA = "0x792D")]
		private void ArtifactDataOnSlotIdChangedEvent()
		{
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x792E", Offset = "0x792E", VA = "0x792E")]
		private void ArtifactDataOnIsFreshChangedEvent()
		{
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x792F", Offset = "0x792F", VA = "0x792F")]
		private void ArtifactDataOnIsFreshWatchedChangedEvent()
		{
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x7930", Offset = "0x7930", VA = "0x7930")]
		private void ArtifactDataOnIsFavoriteChangedEvent()
		{
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x7931", Offset = "0x7931", VA = "0x7931")]
		private void RenderView()
		{
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x7932", Offset = "0x7932", VA = "0x7932")]
		private void AddNote(Sprite icon, string text)
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x7933", Offset = "0x7933", VA = "0x7933")]
		public ArtifactNotesView()
		{
		}

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ArtifactNoteView _noteViewPrefab;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _content;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _notesCont;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _favIcon;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _bestIcon;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _freshIcon;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Sprite _equippedIcon;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x30")]
		private List<ArtifactNoteView> _notes;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x34")]
		private ArtifactData _artifactData;
	}
}
