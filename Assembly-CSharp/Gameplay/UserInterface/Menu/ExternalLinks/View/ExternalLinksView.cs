using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.UserInterface.Menu.ExternalLinks.View
{
	// Token: 0x020003E4 RID: 996
	[Token(Token = "0x20003E4")]
	[DisallowMultipleComponent]
	public class ExternalLinksView : MonoBehaviour
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000409")]
		public Transform ButtonsContainer
		{
			[Token(Token = "0x600174A")]
			[Address(RVA = "0x6908", Offset = "0x6908", VA = "0x6908")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700040A")]
		public ExternalLinkButtonView ButtonPrefab
		{
			[Token(Token = "0x600174B")]
			[Address(RVA = "0x6909", Offset = "0x6909", VA = "0x6909")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600174C")]
		[Address(RVA = "0x690A", Offset = "0x690A", VA = "0x690A")]
		public ExternalLinksView()
		{
		}

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _buttonsContainer;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ExternalLinkButtonView _buttonPrefab;
	}
}
