using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000672 RID: 1650
	[Token(Token = "0x2000672")]
	public class ArtifactNoteView : MonoBehaviour
	{
		// Token: 0x17000794 RID: 1940
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000794")]
		public Sprite Icon
		{
			[Token(Token = "0x60027FD")]
			[Address(RVA = "0x7922", Offset = "0x7922", VA = "0x7922")]
			set
			{
			}
		}

		// Token: 0x17000795 RID: 1941
		// (set) Token: 0x060027FE RID: 10238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000795")]
		public string Text
		{
			[Token(Token = "0x60027FE")]
			[Address(RVA = "0x7923", Offset = "0x7923", VA = "0x7923")]
			set
			{
			}
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x7924", Offset = "0x7924", VA = "0x7924")]
		public ArtifactNoteView()
		{
		}

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _icon;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _text;
	}
}
