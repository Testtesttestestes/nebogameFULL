using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core;
using Core.Data.InfoRows;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace UI.Requirements
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public class RequirementsView : MonoBehaviour, IAsyncLoadableContent
	{
		// Token: 0x140000E3 RID: 227
		// (add) Token: 0x06000BB0 RID: 2992 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000BB1 RID: 2993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000E3")]
		public event Action<IAsyncLoadableContent> ReadyEvent
		{
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0x5EC9", Offset = "0x5EC9", VA = "0x5EC9", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0x5ECA", Offset = "0x5ECA", VA = "0x5ECA", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public IInformationProvider Data
		{
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0x5ECB", Offset = "0x5ECB", VA = "0x5ECB")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x5ECC", Offset = "0x5ECC", VA = "0x5ECC")]
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00003C78 File Offset: 0x00001E78
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		public bool IsReady
		{
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x5ECD", Offset = "0x5ECD", VA = "0x5ECD", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x5ECE", Offset = "0x5ECE", VA = "0x5ECE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x5ECF", Offset = "0x5ECF", VA = "0x5ECF")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x1F83", Offset = "0x1F83", VA = "0x1F83")]
		private RequirementsView.RowPrefabConfig GetRowPrefab(InformationRowTypes type)
		{
			return null;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x5ED0", Offset = "0x5ED0", VA = "0x5ED0", Slot = "7")]
		public virtual void RemoveAll()
		{
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x5ED1", Offset = "0x5ED1", VA = "0x5ED1")]
		private IEnumerator DelayedCall()
		{
			return null;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x5ED2", Offset = "0x5ED2", VA = "0x5ED2")]
		public RequirementsView()
		{
		}

		// Token: 0x0400056A RID: 1386
		[Token(Token = "0x400056A")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected Color32 _titleColor;

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected Color32 _textColor;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected TextAnchor _containerContentAlign;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		protected HorizontalAlignmentOptions _contentHorizontalTextAlignment;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected VerticalAlignmentOptions _contentVerticalTextAlignment;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected RequirementsView.RowPrefabConfig[] _prefabsByTypes;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _separatorPrefab;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x2C")]
		private IInformationProvider _data;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine _delayedCallRoutine;

		// Token: 0x020001B8 RID: 440
		[Token(Token = "0x20001B8")]
		[Serializable]
		public class RowPrefabConfig
		{
			// Token: 0x06000BBB RID: 3003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x5ED3", Offset = "0x5ED3", VA = "0x5ED3")]
			public RowPrefabConfig()
			{
			}

			// Token: 0x04000575 RID: 1397
			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x8")]
			public InformationRowTypes Type;

			// Token: 0x04000576 RID: 1398
			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0xC")]
			public TitleRowView Prefab;
		}
	}
}
