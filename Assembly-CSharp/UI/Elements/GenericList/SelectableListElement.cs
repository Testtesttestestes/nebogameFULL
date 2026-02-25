using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Elements.GenericList
{
	// Token: 0x0200022A RID: 554
	[Token(Token = "0x200022A")]
	public abstract class SelectableListElement<T> : GenericListElement<T> where T : SelectableListElementArgs
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D1")]
		public T Data
		{
			[Token(Token = "0x6000DC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DC5")]
			set
			{
			}
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC6")]
		private void DataChangedEventHandler()
		{
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC8")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC9")]
		protected override void OnInit(T args)
		{
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCA")]
		private void SelectChangedEventHandler(bool select)
		{
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCB")]
		protected virtual void Select(bool isSelected)
		{
		}

		// Token: 0x06000DCC RID: 3532
		[Token(Token = "0x6000DCC")]
		protected abstract void CallElementClickedEvent(T args);

		// Token: 0x06000DCD RID: 3533
		[Token(Token = "0x6000DCD")]
		protected abstract void ApplyArgs();

		// Token: 0x06000DCE RID: 3534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DCE")]
		protected SelectableListElement()
		{
		}

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected GameObject _selectedImage;
	}
}
