using System;
using AssetContent;
using Gameplay.Clans.Office.Controller;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Clans.Office.View
{
	// Token: 0x02000A00 RID: 2560
	[Token(Token = "0x2000A00")]
	public class ClansButtonView : MonoBehaviour
	{
		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06003CEC RID: 15596 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C05")]
		public GameAnimatedButton GameAnimatedButton
		{
			[Token(Token = "0x6003CEC")]
			[Address(RVA = "0x8BAC", Offset = "0x8BAC", VA = "0x8BAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CED")]
		[Address(RVA = "0x8BAD", Offset = "0x8BAD", VA = "0x8BAD")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEE")]
		[Address(RVA = "0x8BAE", Offset = "0x8BAE", VA = "0x8BAE")]
		private void Start()
		{
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CEF")]
		[Address(RVA = "0x8BAF", Offset = "0x8BAF", VA = "0x8BAF")]
		public ClansButtonView()
		{
		}

		// Token: 0x040021CC RID: 8652
		[Token(Token = "0x40021CC")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAnimatedButton _gameAnimatedButton;

		// Token: 0x040021CD RID: 8653
		[Token(Token = "0x40021CD")]
		[FieldOffset(Offset = "0x14")]
		private ClansButtonViewMediator _mediator;
	}
}
