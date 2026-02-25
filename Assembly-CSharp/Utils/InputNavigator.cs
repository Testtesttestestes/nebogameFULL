using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Utils
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	public class InputNavigator : MonoBehaviour
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x56E0", Offset = "0x56E0", VA = "0x56E0")]
		private void Start()
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x56E1", Offset = "0x56E1", VA = "0x56E1")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x56E2", Offset = "0x56E2", VA = "0x56E2")]
		private void OnEnable()
		{
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x56E3", Offset = "0x56E3", VA = "0x56E3")]
		private void OnDisable()
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x56E4", Offset = "0x56E4", VA = "0x56E4")]
		private void SelectElement(InputAction.CallbackContext ctx)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x56E5", Offset = "0x56E5", VA = "0x56E5")]
		public void SetIndex(int value)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x56E6", Offset = "0x56E6", VA = "0x56E6")]
		private List<Selectable> GetVisibleItems()
		{
			return null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x56E7", Offset = "0x56E7", VA = "0x56E7")]
		public InputNavigator()
		{
		}

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private InputAction _selectElementAction;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool _selectOnStart;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Selectable[] _items;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x1C")]
		private readonly List<Selectable> _visibleItems;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x20")]
		private int _index;
	}
}
