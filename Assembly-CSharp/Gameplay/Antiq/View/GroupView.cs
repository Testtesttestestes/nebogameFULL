using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Antiq.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Antiq.View
{
	// Token: 0x02000D87 RID: 3463
	[Token(Token = "0x2000D87")]
	internal class GroupView : AbstractDataRenderer<GroupData>, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x14000201 RID: 513
		// (add) Token: 0x060054BD RID: 21693 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060054BE RID: 21694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000201")]
		public event Action<GroupData> ClickEvent
		{
			[Token(Token = "0x60054BD")]
			[Address(RVA = "0xA269", Offset = "0xA269", VA = "0xA269")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60054BE")]
			[Address(RVA = "0xA26A", Offset = "0xA26A", VA = "0xA26A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0xA26B", Offset = "0xA26B", VA = "0xA26B", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C0")]
		[Address(RVA = "0xA26C", Offset = "0xA26C", VA = "0xA26C", Slot = "19")]
		protected override void HandleDataChanged()
		{
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0xA26D", Offset = "0xA26D", VA = "0xA26D", Slot = "20")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x060054C2 RID: 21698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054C2")]
		[Address(RVA = "0xA26E", Offset = "0xA26E", VA = "0xA26E")]
		public GroupView()
		{
		}

		// Token: 0x04002DEA RID: 11754
		[Token(Token = "0x4002DEA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewRawImage _image;

		// Token: 0x04002DEB RID: 11755
		[Token(Token = "0x4002DEB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TMP_Text _levelField;

		// Token: 0x04002DEC RID: 11756
		[Token(Token = "0x4002DEC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Transform _availMaxLevel;

		// Token: 0x04002DED RID: 11757
		[Token(Token = "0x4002DED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] _availFrame;
	}
}
