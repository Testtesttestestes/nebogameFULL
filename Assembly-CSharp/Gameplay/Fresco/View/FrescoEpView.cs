using System;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007EF RID: 2031
	[Token(Token = "0x20007EF")]
	[AddComponentMenu("Fresco/View/EntryPoint/FrescoEpView")]
	public class FrescoEpView : MonoBehaviour
	{
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700095A")]
		public FrescoFieldMini Field
		{
			[Token(Token = "0x6002FB9")]
			[Address(RVA = "0x801F", Offset = "0x801F", VA = "0x801F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700095B")]
		public MonoPointerClickHandler ClickSource
		{
			[Token(Token = "0x6002FBA")]
			[Address(RVA = "0x8020", Offset = "0x8020", VA = "0x8020")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x8021", Offset = "0x8021", VA = "0x8021")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x8022", Offset = "0x8022", VA = "0x8022")]
		private void Start()
		{
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x8023", Offset = "0x8023", VA = "0x8023")]
		public FrescoEpView()
		{
		}

		// Token: 0x04001A12 RID: 6674
		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickSource;

		// Token: 0x04001A13 RID: 6675
		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private FrescoFieldMini _field;

		// Token: 0x04001A14 RID: 6676
		[Token(Token = "0x4001A14")]
		[FieldOffset(Offset = "0x18")]
		private IViewMediator _mediator;
	}
}
