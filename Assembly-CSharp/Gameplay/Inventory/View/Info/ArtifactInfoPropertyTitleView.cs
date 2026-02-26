using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Inventory.View.Info
{
	// Token: 0x0200066C RID: 1644
	[Token(Token = "0x200066C")]
	public class ArtifactInfoPropertyTitleView : MonoBehaviour
	{
		// Token: 0x17000791 RID: 1937
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000791")]
		public string Title
		{
			[Token(Token = "0x60027ED")]
			[Address(RVA = "0x7913", Offset = "0x7913", VA = "0x7913")]
			set
			{
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027EE")]
		[Address(RVA = "0x7914", Offset = "0x7914", VA = "0x7914")]
		public ArtifactInfoPropertyTitleView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_Inventory_View_Info_ArtifactInfoPropertyTitleView___ctor
		          (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12635);
		    DAT_ram_00a5a0c4 = '\x01';
		  }
		  return StringLiteral_12635;
		}
		*/

		}

		// Token: 0x040015EB RID: 5611
		[Token(Token = "0x40015EB")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;
	}
}
