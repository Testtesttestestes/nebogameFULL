using System;
using Core.Data.InfoRows;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x0200067C RID: 1660
	[Token(Token = "0x200067C")]
	public class TitleRowView : MonoBehaviour
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x00007A40 File Offset: 0x00005C40
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079D")]
		public int Index
		{
			[Token(Token = "0x6002833")]
			[Address(RVA = "0x7955", Offset = "0x7955", VA = "0x7955")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002834")]
			[Address(RVA = "0x1F7D", Offset = "0x1F7D", VA = "0x1F7D")]
			set
			{
			}
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x7956", Offset = "0x7956", VA = "0x7956", Slot = "4")]
		protected virtual void HandleIndexChanged()
		{
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002837 RID: 10295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079E")]
		public IInformationRow Data
		{
			[Token(Token = "0x6002836")]
			[Address(RVA = "0x7957", Offset = "0x7957", VA = "0x7957")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002837")]
			[Address(RVA = "0x1F84", Offset = "0x1F84", VA = "0x1F84")]
			set
			{
			}
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x7958", Offset = "0x7958", VA = "0x7958", Slot = "5")]
		protected virtual void HandleDataChanged()
		{
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x7959", Offset = "0x7959", VA = "0x7959", Slot = "6")]
		public virtual void SetTitle(string value)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x795A", Offset = "0x795A", VA = "0x795A", Slot = "7")]
		public virtual void SetTitleColor(in Color32 color)
		{
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x00007A58 File Offset: 0x00005C58
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079F")]
		public virtual HorizontalAlignmentOptions HorizontalAlignmentTitleText
		{
			[Token(Token = "0x600283B")]
			[Address(RVA = "0x795B", Offset = "0x795B", VA = "0x795B", Slot = "8")]
			get
			{
				return (HorizontalAlignmentOptions)0;
			}
			[Token(Token = "0x600283C")]
			[Address(RVA = "0x795C", Offset = "0x795C", VA = "0x795C", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x00007A70 File Offset: 0x00005C70
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A0")]
		public virtual VerticalAlignmentOptions VerticalAlignmentTitleText
		{
			[Token(Token = "0x600283D")]
			[Address(RVA = "0x795D", Offset = "0x795D", VA = "0x795D", Slot = "10")]
			get
			{
				return (VerticalAlignmentOptions)0;
			}
			[Token(Token = "0x600283E")]
			[Address(RVA = "0x795E", Offset = "0x795E", VA = "0x795E", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A1")]
		public virtual TextAnchor ContainerAlign
		{
			[Token(Token = "0x600283F")]
			[Address(RVA = "0x795F", Offset = "0x795F", VA = "0x795F", Slot = "12")]
			set
			{
			}
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x7960", Offset = "0x7960", VA = "0x7960")]
		public TitleRowView()
		{
		}

		// Token: 0x0400162B RID: 5675
		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextMeshProUGUI _titleField;

		// Token: 0x0400162C RID: 5676
		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bgImage;

		// Token: 0x0400162D RID: 5677
		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x18")]
		[FormerlySerializedAs("_lightBgSprite")]
		[SerializeField]
		private Sprite _evenBgSprite;

		// Token: 0x0400162E RID: 5678
		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x1C")]
		protected int _index;

		// Token: 0x0400162F RID: 5679
		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x20")]
		protected IInformationRow _data;
	}
}
