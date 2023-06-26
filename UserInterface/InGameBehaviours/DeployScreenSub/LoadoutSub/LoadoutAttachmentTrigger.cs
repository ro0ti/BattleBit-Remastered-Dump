using System;
using touching_your_mom;
using UnityEngine;

namespace UserInterface.InGameBehaviours.DeployScreenSub.LoadoutSub
{
	// Token: 0x020007B7 RID: 1975
	[Token(Token = "0x20007B7")]
	public class LoadoutAttachmentTrigger : MonoBehaviour
	{
		// Token: 0x06013D31 RID: 81201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D31")]
		[Address(RVA = "0x17F3AB0", Offset = "0x17F2EB0", VA = "0x1817F3AB0")]
		private void Update()
		{
		}

		// Token: 0x06013D32 RID: 81202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D32")]
		[Address(RVA = "0x17F3770", Offset = "0x17F2B70", VA = "0x1817F3770")]
		private void HandlePosition()
		{
		}

		// Token: 0x06013D33 RID: 81203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6013D33")]
		[Address(RVA = "0x8AA4B0", Offset = "0x8A98B0", VA = "0x1808AA4B0")]
		public LoadoutAttachmentTrigger()
		{
		}

		// Token: 0x04003C28 RID: 15400
		[Token(Token = "0x4003C28")]
		[FieldOffset(Offset = "0x18")]
		public Transform Target;

		// Token: 0x04003C29 RID: 15401
		[Token(Token = "0x4003C29")]
		[FieldOffset(Offset = "0x20")]
		public RectTransform rectTransform;
	}
}
