using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.AccountLinker.View
{
	// Token: 0x02000DFF RID: 3583
	[Token(Token = "0x2000DFF")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Button))]
	public class InfoButtonController : MonoBehaviour
	{
		// Token: 0x06005760 RID: 22368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005760")]
		[Address(RVA = "0xA4DB", Offset = "0xA4DB", VA = "0xA4DB")]
		private void Start()
		{
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005761")]
		[Address(RVA = "0xA4DC", Offset = "0xA4DC", VA = "0xA4DC")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005762")]
		[Address(RVA = "0xA4DD", Offset = "0xA4DD", VA = "0xA4DD")]
		private void OnInfoClick()
		{
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005763")]
		[Address(RVA = "0xA4DE", Offset = "0xA4DE", VA = "0xA4DE")]
		public InfoButtonController()
		{
		}

		// Token: 0x04002F57 RID: 12119
		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string _descriptionKey;
	}
}
