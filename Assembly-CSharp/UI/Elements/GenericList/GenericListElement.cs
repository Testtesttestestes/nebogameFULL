using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using Utils;

namespace UI.Elements.GenericList
{
	// Token: 0x02000225 RID: 549
	[Token(Token = "0x2000225")]
	public abstract class GenericListElement<TElementArgs> : MonoBehaviour where TElementArgs : GenericListElementArgs
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CC")]
		public TElementArgs args
		{
			[Token(Token = "0x6000DA6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DA7")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x000040F8 File Offset: 0x000022F8
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CD")]
		public bool Initted
		{
			[Token(Token = "0x6000DA8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DA9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAA")]
		public void Init(TElementArgs args)
		{
		}

		// Token: 0x06000DAB RID: 3499
		[Token(Token = "0x6000DAB")]
		protected abstract void OnInit(TElementArgs args);

		// Token: 0x06000DAC RID: 3500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAC")]
		protected virtual void RegisterEvents()
		{
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAD")]
		protected virtual void UnregisterEvents()
		{
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAE")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAF")]
		private void OnClick()
		{
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB0")]
		protected GenericListElement()
		{
		}

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Button _button;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0x0")]
		public TypedUnityEvent<TElementArgs> onClick;
	}
}
